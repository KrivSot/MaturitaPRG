/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 05.05.2021
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Rastry
{
	/// <summary>
	/// Knihovní třída pro grafiku
	/// </summary>
	public static class Grafika
	{
		
		static Bitmap obr;
        private static Bitmap obrPom; 
        private static decimal podR = 0.2989M;
        private static decimal podG = 0.5866M;
        private static decimal podB = 0.1145M;
        private static decimal svetlost;
        private static decimal starasvetlost;
        private static int red;
        private static int green;
        private static int blue;
        
		public static Bitmap BlackAndWhite(int ScrollBarValue, Bitmap image)
		{
			obr = new Bitmap(image);
			for (int i = 0; i < obr.Width; i++)
			{
				for (int j = 0; j < obr.Height; j++)
				{
					Color pixel = obr.GetPixel(i, j);
					red = pixel.R;
					green = pixel.G;
					blue = pixel.B;
					svetlost = (red * podR + green * podG + blue * podB);
					if (svetlost < ScrollBarValue)
					{
						obr.SetPixel(i, j, Color.Black);
					}
					else
					{
						obr.SetPixel(i, j, Color.White);
					}
				}
			}
			return obr;
		}
		
		public static Bitmap Obrys(Bitmap image)
		{
			obr = new Bitmap(image);
			Color pixel;
			for (int i = 0; i < obr.Width; i++)
                {
                    for (int j = 0; j < obr.Height; j++)
                    {
                        pixel = obr.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;
                        starasvetlost = (red * podR + green * podG + blue * podB);

                        if ((i < obr.Width - 1)&&(j < obr.Height - 1))
                        {
                            pixel = obr.GetPixel(i + 1, j + 1);
                            red = pixel.R;
                            green = pixel.G;
                            blue = pixel.B;
                            svetlost = (red * podR + green * podG + blue * podB);
                        }

                        /* if (svetlost < starasvetlost - 40)- stará podmínka, funguje ale ne tak jak by měla*/
                       	if(Math.Abs(starasvetlost - svetlost)>20)
                        {
                            pixel = Color.Black;
                        }
                        else
                        {
                            pixel = Color.White;
                        }

                        obr.SetPixel(i, j, pixel);
                    }
                }
			return obr;
		}
		
		public static Bitmap Relief(Bitmap image,int posuvnik)
		{
			obr = new Bitmap(image);
			Color[,] poleBarev = new Color[obr.Width,obr.Height];
			for(int i = 0; i< obr.Width;i++)
			{
				for(int j = 0; j < obr.Height;j++)
				{
					Color pixel = obr.GetPixel(i,j);
					int red = pixel.R;
					int green = pixel.G;
					int blue = pixel.B;
					svetlost = (red*podR + green * podG + blue* podB);
					Color Cpixel;
					if((j< obr.Height - 2) && (i< obr.Width - 2)) { Cpixel = obr.GetPixel(i+2,j+2); }
					else { Cpixel = obr.GetPixel(i,j); }
					int r = Cpixel.R;
					int g = Cpixel.G;
					int b = Cpixel.B;
					decimal svetlost2 = (r * podR + g * podG + b * podB);
					decimal Csvetlo = (posuvnik + svetlost2-svetlost);
					if(Csvetlo < 0) { Csvetlo = 0; }
					if(Csvetlo > 255) { Csvetlo = 255; }
					int Barva = Convert.ToInt32(Csvetlo);
					Color color = Color.FromArgb(Barva, Barva, Barva);
					obr.SetPixel(i,j,color);
				}
			}
			return obr;
		}
		
		public static Bitmap ZmenaBarev(Bitmap image, int R, int G, int B)
		{
			obr = new Bitmap(image);
			float red = R / 100f;
			float green = G / 100f;
			float blue = B / 100f;
			Graphics g = Graphics.FromImage(obr);
			ColorMatrix matice = new ColorMatrix(new float[][]{new float[] {red, green, blue, 0, 0},
			                                     	new float[] {red, green, blue, 0, 0},
			                                     	new float[] {red, green, blue, 0, 0},
			                                     	new float[] {0, 0, 0, 1, 0},
			                                     	new float[] {0, 0, 0, 0, 1},});
			ImageAttributes ai = new ImageAttributes();
			ai.SetColorMatrix(matice);
			g.DrawImage(obr, new Rectangle(0, 0, obr.Width, obr.Height), 0, 0, obr.Width, obr.Height, GraphicsUnit.Pixel, ai);
			g.Dispose();
			return obr;
		}
		
		public static Bitmap šeď(Bitmap image)
		{
			obr = new Bitmap(image);
			for (int i = 0; i < obr.Width; i++)
			{
				for (int j = 0; j < obr.Height; j++)
				{
					Color pixel = obr.GetPixel(i, j);
					red = pixel.R;
					green = pixel.G;
					blue = pixel.B;
					svetlost = (red * podR + green * podG + blue * podB);
					obr.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(svetlost), Convert.ToInt32(svetlost), Convert.ToInt32(svetlost))); //- lepší černo bílý obrázek
				}
            }
			return obr;
		}
		
		public static Bitmap Zvětšení(Bitmap image)
		{
			obr = image;
			Bitmap obrn;
            obrn = new Bitmap(obr.Width*2, obr.Height*2);
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
            return obrn;
		}
		
		public static Bitmap Negativ(Bitmap image)
		{
			obr = image;
			for (int i = 0; i < obr.Width; i++)
            {
            	for (int j = 0; j < obr.Height; j++)
				{
					Color pixel = obr.GetPixel(i, j);
					//získání hodnoty
					alpha = pixel.A;
					red = pixel.R;
					green = pixel.G;
					blue = pixel.B;
                        
					//negace hodnoty
					alpha = 255 - alpha;
					red = 255 - red;
					green = 255 - green;
					blue = 255 - blue;
                       
					obr.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));
				}
			}
			return obr;
		}
		
	}
}
