# Nezdokumentováno (Prozatím)
- Jestli chcete zde můžete si přečíst prozatím nezdokumentovaný kód

```Python

        #region Převedení pixelů na šeď
        private void šeď(object sender, EventArgs e)
        {
        	obr = new Bitmap(pictureBox1.Image);
            if (obr != null)
            {
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
                pictureBox2.Image = obr;
            }
            else { Warning(); }
        }
        #endregion

        #region zvětšení obrázku
        private void zvětšení_obrázku(object sender, EventArgs e)
        {
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
            else { Warning(); }
        }
        #endregion
        
        #region Výřez obrázku
        private void výřezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBtm;
            Color pixel;
            newBtm = new Bitmap(obr.Width*2, obr.Height*2);
            for (int i = bodSpusteni.X+1; i < x; i++)
            {
                for (int j = bodSpusteni.Y+1; j < y; j++)
                {
                    pixel = obr.GetPixel(i, j);
                    newBtm.SetPixel(2 * i, 2 * j, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j, pixel);
                    newBtm.SetPixel(2 * i, 2 * j + 1, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j + 1, pixel);
                }
            }
            Form1 frm1 = new Form1(newBtm, false);
            frm1.Text = "Výřez obrázku";
            frm1.Show(this);
            frm1.Activate();
        }
        #endregion
        
        #region Vykreslení výběru pro výřez
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            bodSpusteni.X = e.X;
            bodSpusteni.Y = e.Y;
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                if (obr != null)
                {
                    obr = new Bitmap(obrPom);
                    int tloustka = Convert.ToInt32(32);
                    Graphics grx = Graphics.FromImage(obr);
                    Pen pero = new Pen(Color.Red);
                    pero.Width = 1;
                    grx.DrawLine(pero, bodSpusteni.X, bodSpusteni.Y, e.X, bodSpusteni.Y);
                    grx.DrawLine(pero, e.X, bodSpusteni.Y, e.X, e.Y);
                    grx.DrawLine(pero, e.X, e.Y, bodSpusteni.X, e.Y);
                    grx.DrawLine(pero, bodSpusteni.X, e.Y, bodSpusteni.X, bodSpusteni.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Image = obr;
                }
                else
                {
                    Warning();
                }
            }
        }
        #endregion
		
        #region konvertování obrázku do znaků
        private void KonvertovatObrázekDoZnakůPLSHELPToolStripMenuItemClick(object sender, EventArgs e)
		{
			/*Bitmap bm = new Bitmap(Image);
			pictureBox2.Image = obr;*/

            Form frm2 = new Form2();
            frm2.Text = "Převod do ASCII";
            frm2.Show(this);
		}
        #endregion

        #region Nedokončeno a dokončeno asi nebude
        void PeroToolStripMenuItemClick(object sender, EventArgs e)
		{
			//pero = true;
		}
       
        
        void PictureBox2MouseMove(object sender, MouseEventArgs e)
		{
            Point novybod = new Point(bodSpusteni.X,bodSpusteni.Y);
            Point novybod1 = new Point(e.X,e.Y);
            if(mousedown)
            {
                if (obr != null)
                {
                    obr = new Bitmap(obrPom);
                    Graphics grx = Graphics.FromImage(obr);
                    Pen pen1 = new Pen(Color.Red, 4);
                    grx.DrawLine(pen1, novybod, novybod1);
                    bodSpusteni.X = e.X;
                    bodSpusteni.Y = e.Y;
                }
                else 
                {
                    Warning();
                }
            }
            pictureBox2.Invalidate();
		}
		void PictureBox2MouseDown(object sender, MouseEventArgs e)
		{
			mousedown = true;
			bodSpusteni.X = e.X;
            bodSpusteni.Y = e.Y;
		}
		void PictureBox2MouseUp(object sender, MouseEventArgs e)
		{
			mousedown = false;
        }
		void NahrazeníBarvyToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3(obr);
			frm3.Text = "";
            frm3.Show(this);
		}
		void NegativToolStripMenuItemClick(object sender, EventArgs e)
		{
			obr=obrPom;
			if (obr != null)
            {
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
                pictureBox2.Image = obr;
            }
            else { Warning(); }
		}
		void CutToolStripButtonClick(object sender, EventArgs e)
		{
			Color pixel = pictureBox2.BackColor;
			for (int i = bodSpusteni.X+1; i < x; i++)
            {
                for (int j = bodSpusteni.Y+1; j < y; j++)
                {
                    //pixel = obr.GetPixel(i, j);
                    obr.SetPixel(i, j, pixel);
                }
            }
			pictureBox2.Image = obr;
		}
		void ReliéfToolStripMenuItemClick(object sender, EventArgs e)
		{
			obr = new Bitmap(obrPom);
			int posuvnik = hScrollBar1.Value;
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
			pictureBox2.Image = obr;
		}
		void ZmenaBarev(object sender, EventArgs e)
		{
			obr = new Bitmap(obrPom);
			float red = RtrackBar.Value / 100f;
			float green = GtrackBar.Value / 100f;
			float blue = BtrackBar.Value / 100f;
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
			pictureBox2.Image = obr;
		}
		
        #endregion
```
