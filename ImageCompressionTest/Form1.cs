using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageCompressionTest
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        Bitmap bmp;
        public Form1()
        {            
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofd.FileName);
                pictureBox1.Image = bmp;
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("comp.dde", FileMode.Create); //Not every bit being written
            BinaryWriter wr = new BinaryWriter(fs);
            string vals = "";
            int j = 0,i = 0;
            //pixel by pixel and put into vals ,when vals becomes size 8 its written into file
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {                    
                    if ((bmp.GetPixel(i, j).R + bmp.GetPixel(i, j).G + bmp.GetPixel(i, j).B) / 3 < 100)
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        vals += "1";
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        vals += "0";
                    }
                    if (vals.Length >= 8)
                    {
                        byte x = Convert.ToByte(vals, 2);
                        wr.Write(x);
                        vals = "";                        
                    }
                }
            }
            
            pictureBox1.Image = bmp;
            wr.Close();
            fs.Close();
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("comp.dde", FileMode.Open);
            BinaryReader rd = new BinaryReader(fs);//Take one byte at a time and then read 1 bit(pixel) and write

            byte[] byteArray = rd.ReadBytes((int)fs.Length);//8 bits .each bit 1 pixel
            //problem convert to string is removing 0s
            Console.WriteLine("Byte array : " + byteArray.Length + " in tot = " + (byteArray.Length*8));
            string individualPixel = "";
            //Getting each pixel
            for (int i = 0; i < byteArray.Length; i++)
            {
                string x = Convert.ToString(byteArray[i], 2);
                //possible problem area , might have to switch placement of padding 0s
                if (x.Length < 8)
                {
                    int diff = 8 - x.Length;
                    for (int q = 0; q < diff; q++)
                    {
                        x = x.Insert(0,"0");
                    }
                }
                individualPixel += x;  
            }
            
            Console.WriteLine("total pixels = " + individualPixel.Length + " res = " + (bmp.Width*bmp.Height));
            //Put pixels on image

            pictureBox2.Image = displayImage(individualPixel, bmp.Width, bmp.Height);

            rd.Close();
            fs.Close();
        }

        Bitmap displayImage(string indPixels,int width,int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            int totLength = indPixels.Length;
            int i = 0;
            int tWidth = 0, tHeight = 0;
            while (i < totLength)
            {
                
                if (tWidth >= width)
                {
                    if(tHeight < height-1)
                        tHeight++;
                    tWidth = 0;
                }
                if(indPixels[i] == '1')
                    bmp.SetPixel(tHeight, tWidth, Color.Black);
                else
                    bmp.SetPixel(tHeight, tWidth, Color.White);
                tWidth++;
                i++;
            }
            return bmp;
        }
    }
}
