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

        int size = 0;//temp value to check before using meta data
        
        public StegnographyForm()
        {
            InitializeComponent();
        }

        private void InputImagePictureBox_DoubleClick(object sender, EventArgs e)
        {
            ofdImage = new OpenFileDialog();
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofdImage.FileName);
                InputImagePictureBox.Image = bmp;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                fileAdressTextBox.Text = ofdFile.FileName;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(ofdFile.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] bArray = br.ReadBytes((int)fs.Length);
            size = bArray.Length;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);

            Console.WriteLine("Length of bytes in original = " + size);
            int k = 0; // starts at 3 to leave space for byte length meta data
            //Each pixel can store a byte array length of 1020

            /*for (int i = 0; i < 3; i++)
            {
                byte A = 0, R =0, G =0, B =0;
                byte[] ar = new byte[4] { A, R, G, B };
                for (int h = 0; h < 4; h++)
                {
                    if (size - 255 >= 255)
                    {
                        ar[h] = 255;
                        size -= 255;
                    }
                    else if (size < 255 && size >= 0)
                    {
                        ar[h] = (byte)size;
                        size = 0;
                    }
                }
                bmp2.SetPixel(i, 0, Color.FromArgb(A,R,G,B));
            }*/

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    byte R = bmp.GetPixel(i, j).R;
                    byte G = bmp.GetPixel(i, j).G;
                    byte B = bmp.GetPixel(i, j).B;
                    if (k < bArray.Length)
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(bArray[k], R, G, B));
                        k++;
                    }
                    else
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                    }
                }
            }
            br.Close();
            fs.Close();

            OutputImagePictureBox.Image = bmp2;
            bmp2.Save("output.bmp");
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp3 = new Bitmap("output.bmp");
            FileStream rf = new FileStream("retrivedFile.bmp", FileMode.Create);
            BinaryWriter wr = new BinaryWriter(rf);

            int genSize = 0;

            for (int i = 0; i < 3; i++)
            {
                genSize += bmp3.GetPixel(i, 0).A + bmp3.GetPixel(i, 0).R + bmp3.GetPixel(i, 0).G + bmp3.GetPixel(i, 0).B;
            }
            Console.WriteLine("Length of bytes = " + genSize);
            int k = 0;

            for (int i = 0; i < bmp3.Width; i++)
            {
                for (int j = 0; j < bmp3.Height; j++)
                {

                    if (k < size)
                    {
                        byte val = bmp3.GetPixel(i, j).A;
                        wr.Write(val);
                        k++;
                    }
                    else
                        break;
                }
            }
            wr.Close();
            rf.Close();
        }
    }
}
