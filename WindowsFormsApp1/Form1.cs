﻿using System;
using System.Threading;
using static System.Drawing.Image;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        // C:\Users\louis\Documents\GitHub\projet-tetris-jourdan\WindowsFormsApp1\data\L.png
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("You pressed PLAY btn");
        }

        private void OptionBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("You pressed OPTION btn");

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //retrieve the chars here 
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                Console.WriteLine("You pressed Up arrow key");

            
                PictureBox t = new PictureBox
                {
                    Image = Properties.Resources.T,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(90, 90),
                    Location = new Point(0, 0),
                    //BackColor = Color.White
                };
                pictureBox1.Controls.Add(t);

                for (int i = 0; i < 500; i+= 20)
                {
                    t.Location = new Point(0, i);
                    Thread.Sleep(500);
                    t.Refresh();
                }
                

                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                Console.WriteLine("You pressed Down arrow key");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                Console.WriteLine("You pressed Left arrow key");
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                Console.WriteLine("You pressed Right arrow key");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
