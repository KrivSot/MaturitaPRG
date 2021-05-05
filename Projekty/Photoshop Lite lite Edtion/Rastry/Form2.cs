/*
 * Created by SharpDevelop.
 * User: janiak
 * Date: 07.03.2019
 * Time: 13:12
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
        private string[] _AsciiChars = { "#", "@", "8", "S", "%", "=", "+", "-", ":", ".", "&nbsp;" };
        //private string[] _AsciiChars = {"██", "##", "@@", "%%", "==", "++","**", "::", "--", "..", " "};  
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        private string _Content;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Tlačítko pro konvertování
        private void btnConvertToAscii_Click(object sender, EventArgs e)
        {
            btnConvertToAscii.Enabled = false;
            Bitmap image = new Bitmap(txtPath.Text, true);
            image = GetReSizedImage(image, this.trackBar.Value);
            _Content = ConvertToAscii(image);
            browserMain.DocumentText = "<pre>" + "<Font size=0>" + _Content + "</Font></pre>";
            btnConvertToAscii.Enabled = true;
        }
        #endregion
        
        #region Konvertování obrázku do ASCII
        private string ConvertToAscii(Bitmap image)
        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);
                    
                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(_AsciiChars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region Změní rozlišení ??
        private Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
        {
            int asciiHeight = 0;
            asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);

            Bitmap result = new Bitmap(320, 180);
            Graphics g = Graphics.FromImage((Image)result); 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, 320, 180);
            g.Dispose();
            return result;
        }
        #endregion

        #region Import obrázku ze souborů
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
        #endregion
    }
}
