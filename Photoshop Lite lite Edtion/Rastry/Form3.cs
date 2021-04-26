/*
 * Created by SharpDevelop.
 * User: janiak
 * Date: 14.03.2019
 * Time: 12:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Rastry
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		Bitmap btm;
		Color[] barva = new Color[10];
		public Form3(Bitmap image)
		{
			InitializeComponent();
		}
		void PictureBox1MouseClick(object sender, MouseEventArgs e)
		{
			Bitmap b = new Bitmap(pictureBox1.Image);
			barva[1] = b.GetPixel(e.X, e.Y);
			pictureBox2.BackColor = barva[1];
		}
		void Button1Click(object sender, EventArgs e)
		{
            /*DialogResult diag = OpenFileDialog.ShowDialog();
            if (diag == DialogResult.OK)
            {
                txtPath.Text = OpenFileDialog.FileName;
            }*/
		}
	}
}
