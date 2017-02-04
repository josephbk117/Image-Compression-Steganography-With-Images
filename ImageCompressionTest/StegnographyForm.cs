using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressionTest 
{
    public partial class StegnographyForm : Form
    {
        OpenFileDialog ofdImage;
        OpenFileDialog ofdFile;
        Bitmap bmp;
        const int sizeAlloc = 512;

        public StegnographyForm()
        {
            InitializeComponent();
        }

        private void InputImagePictureBox_DoubleClick(object sender, EventArgs e)
        {
            ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofdImage.FileName);
                InputImagePictureBox.Image = bmp;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            ofdFile = new OpenFileDialog();
            ofdFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                fileAdressTextBox.Text = ofdFile.FileName;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();            

        }

        OpenFileDialog decryptOfd;
        string openpath = "";
        private void decryptButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp3;

            if (openpath != "")
            {
                bmp3 = new Bitmap(openpath);
            }
            else
            {
                MessageBox.Show("Not put a path");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.BMP)|*.BMP;|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = sfd.FileName;
                FileStream rf = new FileStream(sfd.FileName, FileMode.Create);
                BinaryWriter wr = new BinaryWriter(rf);

                int genSize = 0;

                for (int i = 0; i < sizeAlloc; i++)
                {
                    genSize += bmp3.GetPixel(i, 0).A + bmp3.GetPixel(i, 0).R + bmp3.GetPixel(i, 0).G + bmp3.GetPixel(i, 0).B;
                }

                int k = 0;
                int count = 0;
                for (int i = 0; i < bmp3.Width; i++)
                {
                    for (int j = 0; j < bmp3.Height; j++)
                    {
                        if (k < genSize && count > sizeAlloc)
                        {
                            byte val = bmp3.GetPixel(i, j).R;
                            wr.Write(val);
                            k++;
                        }
                        count++;
                    }
                }
                wr.Close();
                rf.Close();
            }
            MessageBox.Show("Image saved at : " + sfd.FileName);
        }

        private void buttonOpenDecrypt_Click(object sender, EventArgs e)
        {
            decryptOfd = new OpenFileDialog();
            if (decryptOfd.ShowDialog() == DialogResult.OK)
            {
                openpath = decryptOfd.FileName;
                textBoxDecryption.Text = openpath;
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            FileStream fs = new FileStream(ofdFile.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] bArray = br.ReadBytes((int)fs.Length);
            int size = bArray.Length;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);


            int k = 0; 
            
            
            int tempSize = size;

            for (int i = 0; i < sizeAlloc; i++)
            {
                byte A = 0, R = 0, G = 0, B = 0;
                byte[] ar = new byte[4] { A, R, G, B };
                for (int h = 0; h < 4; h++)
                {
                    if (tempSize >= 255)
                    {
                        ar[h] = 255;
                        tempSize -= 255;

                    }
                    else if (tempSize < 255)
                    {
                        ar[h] = (byte)tempSize;
                        tempSize = 0;
                    }

                }
                bmp2.SetPixel(i, 0, Color.FromArgb(ar[0], ar[1], ar[2], ar[3])); //TODO : Can allow multi-line length specification
            }
            int count = 0;
            

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    byte G = bmp.GetPixel(i, j).G;
                    byte B = bmp.GetPixel(i, j).B;

                    if (k < bArray.Length && count > sizeAlloc)
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(255, bArray[k], G, B));
                        k++;
                    }
                    else
                    {
                        byte R = bmp.GetPixel(i, j).R;
                        bmp2.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                    }
                    count++;
                   
                }
                backgroundWorker1.ReportProgress((int)(((double)(i+1)/(double)bmp.Width)*100d));
            }
            
            br.Close();
            fs.Close();
            e.Result = bmp2;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            OutputImagePictureBox.Image = (Bitmap)e.Result;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.BMP)|*.BMP;|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OutputImagePictureBox.Image.Save(sfd.FileName);
            }            

        }
    }
}
