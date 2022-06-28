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

namespace project
{
    
    public partial class Form1 : Form
    {
        List<Image> image1;
        List<Image> image2;
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
        }

        private void добавитьИлиЗаменитьВидео2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();

        }
        bool success;
        int distance;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            success = int.TryParse(textBox1.Text, out distance);
            if (!success)
            {
                MessageBox.Show("Неправильный тип ввода данных, введите значение заново");
                textBox1.Text = "";
            }
            else
            {
                if (int.Parse(textBox1.Text) > trackBar1.Maximum || int.Parse(textBox1.Text) < trackBar1.Minimum)
                {
                    MessageBox.Show("Значение не входит в диапазон от " + trackBar1.Minimum + " до " + trackBar1.Maximum + "/n Введите значение заново");
                    textBox1.Text = "";
                }
                else
                {
                    trackBar1.Value = int.Parse(textBox1.Text);
                }

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
