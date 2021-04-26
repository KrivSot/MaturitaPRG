using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Rastry
{
    public partial class Form1 : Form
    {
        private Bitmap btm;
        bool mousedown;

        public Form1(Bitmap obr, bool kresleni)
        {
            this.btm = obr;
            InitializeComponent();
            //pictureBox1.Image = obr;
            /*Color pixel;
            Bitmap newBtm = btm;*/
            /*newBtm.Size.Width = btm.Width;
            newBtm.Size.Height = btm.Height;*/
            /*for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    //pixel = btm.GetPixel(btm.Width - i, btm.Height - j);
                    pixel = btm.GetPixel(i, j);
                    //newBtm.SetPixel(newBtm.Width-1-i, j, pixel); - otočí obrázek o 90° do prava
                    newBtm.SetPixel(i, j, pixel);
                    //if (i % 1 == 0) newBtm.SetPixel(i, j, Color.White);
                    Thread.Sleep(500);
                }*/
            	//Vykresli();
            
            
            
            //newBtm.RotateFlip(RotateFlipType.Rotate180FlipX); //- Otočí obrázek o 90°
            //pictureBox1.Image = newBtm;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*obr = new Bitmap(btm);
            Graphics grx = Graphics.FromImage(obr);
            Pen pen1 = new Pen(Color.Red);
            pen1.Width = 1;
            grx.DrawLine(pen1, 0, 0, 100, 100);
            if (mousedown)
            {

            }*/
        }
        
        private void Vykresli()
        {
        	Color pixel;
        	Bitmap newBtm = new Bitmap(btm.Width,btm.Height);
            /*newBtm.Size.Width = btm.Width;
            newBtm.Size.Height = btm.Height;*/
            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    //pixel = btm.GetPixel(btm.Width - i, btm.Height - j);
                    pixel = btm.GetPixel(i, j);
                    //newBtm.SetPixel(newBtm.Width-1-i, j, pixel); - otočí obrázek o 90° do prava
                    newBtm.SetPixel(i, j, pixel);
                    //if (i % 1 == 0) newBtm.SetPixel(i, j, Color.White);
                    
                }
                pictureBox1.Image = newBtm;
                //Thread.Sleep(1000);
                pictureBox1.Refresh();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
		void Button1Click(object sender, EventArgs e)
		{
			Vykresli();
		}
    }
}