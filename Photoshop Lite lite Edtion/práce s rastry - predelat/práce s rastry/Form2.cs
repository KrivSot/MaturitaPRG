/*
 * Created by SharpDevelop.
 * User: kryst
 * Date: 27.02.2019
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace práce_s_rastry
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{private Bitmap btm;
		public Form2(Bitmap obr)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			
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
			pictureBox1.Image=newBtm;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
