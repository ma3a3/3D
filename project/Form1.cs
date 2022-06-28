using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using AForge;
using System.Runtime.Serialization.Formatters.Binary;
using Accord.Video.VFW;



    namespace project
    {
        public partial class Form1 : Form
        {
            string os1;
            string os2;
            string iso1;
            string iso2;
            string ss;
            public byte[] imageToByteArray(System.Drawing.Image imageIn)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }

            public void furie()
            {

            }

            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
            {

            }

            private void toolTip1_Popup(object sender, PopupEventArgs e)
            {

            }

            private void добавитьИлиЗаменитьВидео2ToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void добавитьИлиЗаменитьВидео1ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog o = new OpenFileDialog();
                o.ShowDialog();
                os1 = o.FileName;
            }

            private void добавитьИлиЗаменитьВидео2ToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                OpenFileDialog o = new OpenFileDialog();
                o.ShowDialog();
                os2 = o.FileName;

            }
            bool success;
            int distance;
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        public static Bitmap MakeImage(Size ImgSize, Bitmap foreImg, Bitmap backImg, byte s)
        {
            // ImgSize = размер картинки-результата, обе исходные картинки приводятся к указанному размеру 
            // s прозрачность накладываемого изображения foreImg от 0 (100%) до 255 (0%) 
            // результат наследует Альфа-канал фонового изображения 
            // наложение использует Альфа-канал накладываемого изображения 
            Bitmap fimg = new Bitmap(foreImg, ImgSize);
            Bitmap bimg = new Bitmap(backImg, ImgSize);
            Bitmap bmp = new Bitmap(ImgSize.Width, ImgSize.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color fm = fimg.GetPixel(i, j);
                    Color bm = bimg.GetPixel(i, j);
                    byte af = (byte)(fm.A * s / byte.MaxValue);
                    byte a = bm.A;
                    byte r = (byte)((fm.R * af + bm.R * (byte.MaxValue - af)) / byte.MaxValue);
                    byte g = (byte)((fm.G * af + bm.G * (byte.MaxValue - af)) / byte.MaxValue);
                    byte b = (byte)((fm.B * af + bm.B * (byte.MaxValue - af)) / byte.MaxValue);
                    bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                }
            return bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
            {
                
            }

            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
            {
                
            }

            private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.ShowDialog();
            }
        [STAThread]
        private void button2_Click(object sender, EventArgs e)
        {
            //    Bitmap bitmap = new Bitmap("C:\\Users\\ma3a3\\Downloads\\jpg.jpg");
            //    Color[][] mas = new Color[450][];
            //    int middlecolor;
            //    Color pixelColor;
            //    for (int i = 0; i < 450; i++)
            //    {
            //        mas[i] = new Color[450];
            //        for (int j = 0; j < 450; j++)
            //        {
            //            pixelColor = bitmap.GetPixel(i, j);
            //            middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            //            mas[i][j] = Color.FromArgb(pixelColor.R, middlecolor, middlecolor);
            //            bitmap.SetPixel(0, 0, mas[0][0]);
            //        }
            //    }
            //    for (int i = 0; i < 450; i++)
            //    {
            //        mas[i] = new Color[450];
            //        for (int j = 0; j < 450; j++)
            //        {
            //            pixelColor = bitmap.GetPixel(i, j);
            //            middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            //            mas[i][j] = Color.FromArgb(middlecolor, middlecolor, pixelColor.B);
            //        }
            //    }
            //Complex[] complexmas = new Complex[mas.Length];
            //FFT fastfur = new FFT();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    complexmas[i] = FFT.w(mas[i], i + 1);
            //}
            //Complex[] result = FFT.fft(complexmas);
            //result = FFT.nfft(result);
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            ss = s.FileName;
            if (checkBox2.Checked)
            {               
                    if (os1 == null || os2 == null)
                    {
                        MessageBox.Show("Не выбран файл");
                        OpenFileDialog o3 = new OpenFileDialog();
                        o3.ShowDialog();
                        os1 = o3.FileName;
                        OpenFileDialog o4 = new OpenFileDialog();
                        o4.ShowDialog();
                        os2 = o4.FileName;
                }                    
                
                AVIWriter awriter = new AVIWriter();
                AVIReader left = new AVIReader();
                AVIReader right = new AVIReader();
                FileStream fsleft = new FileStream(os1, FileMode.OpenOrCreate);
                FileStream fsright = new FileStream(os2, FileMode.OpenOrCreate);
                Image imgsourcer = new Bitmap("C:\\Users\\ma3a3\\Desktop\\result_image.jpg");
                Image imgsourcel = new Bitmap("C:\\Users\\ma3a3\\Desktop\\result_image.jpg");                
                Bitmap bitmapleft = (Bitmap)imgsourcel;
                Bitmap bitmapright = (Bitmap)imgsourcer;
                Color pixelColor;
                int middlecolor;
                awriter.Codec = "MSVC";
                left.Open(os1);
                right.Open(os2);
                awriter.Open(ss + ".avi", left.Width, left.Height);

                int o = 0;
                while (o < left.Length-2)
                {
                    imgsourcel = left.GetNextFrame();
                    imgsourcer = right.GetNextFrame();
                    for (int i = 0; i < 1280; i++)
                    {
                        bitmapleft = (Bitmap)imgsourcel;
                        for (int j = 0; j < 720; j++)
                        {
                            pixelColor = bitmapleft.GetPixel(i, j);
                            middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            bitmapleft.SetPixel(i, j, Color.FromArgb(middlecolor, 0, 0));
                        }
                    }
                    for (int i = 0; i < 1280; i++)
                    {
                        bitmapright = (Bitmap)imgsourcer;
                        for (int j = 0; j < 720; j++)
                        {
                            pixelColor = bitmapright.GetPixel(i, j);
                            middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            bitmapright.SetPixel(i, j, Color.FromArgb(0, 0, middlecolor));
                        }
                    }
                    awriter.AddFrame(MakeImage(bitmapright.Size, bitmapright, bitmapleft, 150));
                    o++;
                }

                fsleft.Close();
                fsright.Close();
                left.Close();
                right.Close();
                awriter.Close();
            }
            else
            {
                
                    if (iso1 == null || iso2 == null)
                    {
                        MessageBox.Show("Не выбран файл");
                        OpenFileDialog o = new OpenFileDialog();
                        o.ShowDialog();
                        iso1 = o.FileName;
                        OpenFileDialog o2 = new OpenFileDialog();
                        o2.ShowDialog();
                        iso2 = o2.FileName;
                    }
                Image imgsourcel = new Bitmap(iso1);
                Image imgsourcer = new Bitmap(iso2);
                Bitmap bitmapleft = (Bitmap)imgsourcel;
                Bitmap bitmapright = (Bitmap)imgsourcel;
                Color pixelColor;
                int middlecolor;
                for (int i = 0; i < bitmapleft.Width; i++)
                {
                    bitmapleft = (Bitmap)imgsourcel;
                    for (int j = 0; j < bitmapleft.Height; j++)
                    {
                        pixelColor = bitmapleft.GetPixel(i, j);
                        middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        bitmapleft.SetPixel(i, j, Color.FromArgb(middlecolor, 0, 0));
                    }
                }
                for (int i = 0; i < bitmapright.Width; i++)
                {
                    bitmapright = (Bitmap)imgsourcer;
                    for (int j = 0; j < bitmapright.Height; j++)
                    {
                        pixelColor = bitmapright.GetPixel(i, j);
                        middlecolor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        bitmapright.SetPixel(i, j, Color.FromArgb(0, 0, middlecolor));
                    }
                }
                imgsourcer = MakeImage(bitmapright.Size, bitmapright, bitmapleft, 128);
                imgsourcer.Save(ss+".jpg");
                MessageBox.Show("Алгоритм завершил работу");
            }

        }

        private void создать3DИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void создать3DИзображениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void создать3DВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            checkBox2.Checked = false;
            изображениеToolStripMenuItem.Enabled = true;
            добавитьИлиЗаменитьВидео2ToolStripMenuItem.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            изображениеToolStripMenuItem.Enabled = false;
            добавитьИлиЗаменитьВидео2ToolStripMenuItem.Enabled = true;
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьИлиЗаменитьВидео2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            iso1 = o.FileName;
        }

        private void добавитьИлиЗаменитьИзображение1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            iso2 = o.FileName;
        }
    }
    }

