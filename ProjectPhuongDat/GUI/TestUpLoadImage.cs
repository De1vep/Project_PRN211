﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPhuongDat.GUI
{
    public partial class TestUpLoadImage : Form
    {
        public TestUpLoadImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //up load image cho albums 
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Image file";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*gif)| *.jpg;*.jpeg;*.png;*.gif";

                ofd.ShowDialog();
                if (ofd.FileName == "")
                    return;
                string filename = ofd.FileName;
                string[] str = filename.Split("\\");
                pictureBox1.ImageLocation = filename;
                MessageBox.Show(filename.ToString());
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + "Resources\\Images\\" + str.Last(), true);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox2.ImageLocation = pictureBox1.ImageLocation;

        }

        private void TestUpLoadImage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = RandomString(20);
        }

        private string RandomString(int size)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }


            return sb.ToString().ToLower();

            return sb.ToString();
        }
    }
}
