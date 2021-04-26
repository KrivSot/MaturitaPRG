/*
 * Created by SharpDevelop.
 * User: cejchank
 * Date: 30.01.2019
 * Time: 8:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace práce_s_rastry
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Form exitform=new Form();
		public static Bitmap obr;
		public static Bitmap obrPom;
		private static decimal podR=0.2989M;
		private static decimal podG=0.5866M;
		private static decimal podB=0.1145M;
		private static decimal svetlost;
		private static decimal svetlost2;
	//	private static decimal sedost;
	Point lastPoint = Point.Empty;
	bool kreslit=false;
 
        bool isMouseDown = new Boolean();
		Color pixelokusdal;
	
	
		

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void OtevřítToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.FileName="...";
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				obr=new Bitmap(openFileDialog1.FileName);
				pictureBox1.Load(openFileDialog1.FileName);
				obrPom=new Bitmap(openFileDialog1.FileName);
			}
		}
		void ZavřítToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Opravdu chcete odejít?");
			
			this.Close();
	
		}
		void KopiePoPixeluToolStripMenuItemClick(object sender, EventArgs e)
		{
		/*	Form1 Frm1=new Form1(obr);
		Frm1.Text="Kopie obr po pixelu";	
		Frm1.Show(this);
		Frm1.Activate();*/
			
		}
		void ToolStripButton3Click(object sender, EventArgs e)
		{
	openFileDialog1.FileName="...";
	
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				obr=new Bitmap(openFileDialog1.FileName);
				pictureBox1.Load(openFileDialog1.FileName);
				obrPom=new Bitmap(openFileDialog1.FileName);
			}
		}
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			if(this.BackColor==Color.DarkGray){
				this.BackColor=Color.Silver;}
			else
			{this.BackColor=Color.DarkGray;}
			
		}
		public static Bitmap Obr
		{
	
			get{return obr;}
		
		}
		void BlackWhiteToolStripMenuItemClick(object sender, EventArgs e)
		{
			for(int i=0;i<obr.Width;i++)
			{
				for(int j=0;j<obr.Height;j++)
				{
					Color pixel = obr.GetPixel(i,j);
					int red=pixel.R;
					int green=pixel.G;
					int blue=pixel.B;
					svetlost=(red*podR+green*podG+blue*podB);
					if(svetlost<255/2)
					{obrPom.SetPixel(i,j,Color.Black);}
					
					else{obrPom.SetPixel(i,j,Color.White);}
				}
			
			}
			pictureBox2.Image=obrPom;
		}
		void HScrollBar1ValueChanged(object sender, EventArgs e)
		{
	for(int i=0;i<obr.Width;i++)
			{
				for(int j=0;j<obr.Height;j++)
				{
					Color pixel = obr.GetPixel(i,j);
					int red=pixel.R;
					int green=pixel.G;
					int blue=pixel.B;
					svetlost=(red*podR+green*podG+blue*podB);
					if(svetlost<hScrollBar1.Value)
					{obrPom.SetPixel(i,j,Color.Black);}
					//if(svetlost>355-123){obrPom.SetPixel(i,j,Color.White);}
					else{obrPom.SetPixel(i,j,Color.White);}
				}
			
			}
			pictureBox2.Image=obrPom;
		}
		void ObrysyToolStripMenuItemClick(object sender, EventArgs e)
		{
	for(int i=1;i<obr.Width;i++)
			{
				for(int j=0;j<obr.Height;j++)
				{
					Color pixel = obr.GetPixel(i,j);
			
					pixelokusdal=obr.GetPixel(i-1,j);
				
				   int red=pixel.R;
					int green=pixel.G;
					int blue=pixel.B;
				
					int red2=pixelokusdal.R;
					int green2=pixelokusdal.G;
					int blue2=pixelokusdal.B;
					svetlost=(red*podR+green*podG+blue*podB);
					svetlost2=(red2*podR+green2*podG+blue2*podB);
					if(svetlost-svetlost2<10||svetlost-svetlost2>245)
					{obrPom.SetPixel(i,j,Color.White);}
					
					
					else{obrPom.SetPixel(i,j,Color.Black);}
				}
			
			}
			pictureBox2.Image=obrPom;
		}
		void OdstínůŠediToolStripMenuItemClick(object sender, EventArgs e)
		{
	for(int i=0;i<obr.Width;i++)
			{
				for(int j=0;j<obr.Height;j++)
				{
					Color pixel = obr.GetPixel(i,j);
			
				
				
				    int red=pixel.R;
					int green=pixel.G;
					int blue=pixel.B;
					svetlost=(red*podR+green*podG+blue*podB);
					
					if(svetlost<0){svetlost=0;}
					if(svetlost>255){svetlost=255;}
					 int barva=Convert.ToInt32(svetlost);
					Color color=Color.FromArgb(barva,barva,barva);
					obrPom.SetPixel(i,j,color);
					
					
					
				}
	}
	pictureBox2.Image=obrPom;
		}
		void ZoomInToolStripMenuItemClick(object sender, EventArgs e)
		{
	/*for(int i=0;i<obr.Width*2;i++)
			{
				for(int j=0;j<obr.Height*2;j++)
				{
					
					Color pixel = obr.GetPixel(i,j);
			
				
					obrPom.SetPixel(i,j,pixel);
					obrPom.SetPixel((i*2)+1,j,pixel);
					obrPom.SetPixel(i,(j*2)+1,pixel);
					obrPom.SetPixel((i*2)+1,(j*2)+1,pixel);
					
					
					
					
		
		}pictureBox2.Image=obrPom;}*/
	 Bitmap obrn;
	 
            obrn = new Bitmap(obr.Width*2, obr.Height*2);
            if (obr != null)
            {
                for (int i = 0; i < obr.Width; i++)
                {
                    for (int j = 0; j < obr.Height; j++)
                    {
                        Color pixel = obr.GetPixel(i, j);
                        obrn.SetPixel(2 * i, 2 * j, pixel);
                        obrn.SetPixel(2 * i + 1, 2 * j, pixel);
                        obrn.SetPixel(2 * i, 2 * j + 1, pixel);
                        obrn.SetPixel(2 * i + 1, 2 * j + 1, pixel);
                    }
                }
                pictureBox2.Image = obrn;
            }
            else {  }
		
		}
		

	
		
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{kreslit=true;
			
			Graphics gr=Graphics.FromImage(obr);
			
			if(kreslit)
			{
//int tloustka=     ;

Pen pen1=new System.Drawing.Pen(System.Drawing.Color.Red);
pen1.Width=1;
gr.DrawLine(pen1,0,0,100,100);

			}



			}
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			kreslit=false;
		}
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
			int mousex=MousePosition.X;
			int mousey=MousePosition.Y;
			
			
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
	Form1 Frm1=new Form1(obr);
		Frm1.Text="Kopie obr po pixelu";	
		Frm1.Show(this);
		Frm1.Activate();
		}
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
	Form2 Frm2=new Form2(obr);
		Frm2.Text="Kopie obr po pixelu";	
		Frm2.Show(this);
		Frm2.Activate();
		}
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
	Form3 Frm3=new Form3(obr);
		Frm3.Text="Kopie obr po pixelu";	
		Frm3.Show(this);
		Frm3.Activate();
		}
		void KresleníPeremToolStripMenuItemClick(object sender, EventArgs e)
		{
			pictureBox2.Image=obr;
		}
		void PictureBox2MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = e.Location;
 
            isMouseDown = true;
		}
		void PictureBox2MouseMove(object sender, MouseEventArgs e)
		{
	 if (isMouseDown == true)
 
            {
 
               // if (lastPoint != null)
 
               // {
 
                    if (pictureBox2.Image == null) 
                    {
                        
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
 
                        pictureBox2.Image = bmp; 
 
                    }
 
                    using (Graphics g = Graphics.FromImage(pictureBox2.Image))
 
                    {
 
                                        g.DrawLine(new Pen(Color.Red, 2), lastPoint, e.Location);
                       
 
                    }
 
                    pictureBox2.Invalidate();
 
                    lastPoint = e.Location;
 
               // }
 
            }
		}
		void PictureBox2MouseLeave(object sender, EventArgs e)
		{
			isMouseDown=false;
			
		}
		void PictureBox2MouseEnter(object sender, EventArgs e)
		{
			//isMouseDown=true;
		}
		
		
		
		}
	
		//pro vytvoření černo-bílého obr, pottřebujeme zjistit světlost pixelu,
		//pixel je barva skládající se ze tří barev, 
		//nejvíce se na světlosti podílí barva zelená a to 60% 0.5866M, červená 30% 0.2989M, modrá 10% 0.1145M.
		
	}

