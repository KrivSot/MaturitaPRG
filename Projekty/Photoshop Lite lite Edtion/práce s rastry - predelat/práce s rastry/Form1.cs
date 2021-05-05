/*
 * Created by SharpDevelop.
 * User: cejchank
 * Date: 31.01.2019
 * Time: 12:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace práce_s_rastry
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		private Bitmap btm;
		
		
		
		public Form1(Bitmap obr)
		{ 
			//
			InitializeComponent();
			//
			/*pictureBox3.Width=this.Width;
			pictureBox3.Height=this.Height;*/
			this.btm=obr;
			//pictureBox3.Image=obr;
		Color pixel;
		btm.RotateFlip(RotateFlipType.Rotate90FlipXY);
			Bitmap newBtm=btm;
		//	newBtm.Size.Width=btm.Width;
	//		newBtm.Size.Height=btm.Height;
			/*for(int i=0;i< btm.Width;i++)
			{
				for(int j=0;j<btm.Height;j++)
				{ // i=šířka(x), j=výška(y)
					
					pixel=btm.GetPixel(i,j);
					newBtm.SetPixel(newBtm.Width-1-i,j,pixel);
				
				
				}
				
			}*/
			pictureBox3.Image=newBtm;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
	}
}
