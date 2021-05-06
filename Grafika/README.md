# Potřebné reference

```C#
using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
```

# Důležité proměnné

```C#
//RGB hodnoty pixelu
private int red;
private int green;
private int blue;

private static Bitmap obr; // Bitmapa do které uložíme upravený obrázek
private static Bitmap obrPom; //Bitmapa neupraveného obrázku

/* Tyto tři hodnoty nám pomůžou s konvertováním obrázku na stupně šedi
* Je to vlastně počet v procentech, jak moc se určitá barva podílí na světlosti
*/
private static decimal podR = 0.2989M; 
private static decimal podG = 0.5866M;
private static decimal podB = 0.1145M;
//Hodnoty světlosti pixelu
private static decimal svetlost;
private static decimal starasvetlost;
// Tyto hodnoty pomůžou s výřezem obrázku
private bool mousedown; // Určuje, jestli je tlačítko myši stisknuté
private Point bodSpusteni = new Point(); //Bod, do kterého se uloží počáteční kliknutí na PictureBoxu
private int x;
private int y;
```
# Jak vypadá kód
- Vetšinou si vytvoříme obslužnou metodu události Click a v ní zavoláme funkci knihovní třídy
- Příklad:
```C#
//Obslužná metoda události Click, kterou sem přiřadil MenuStripItemu
private void blackandWhite(object sender, EventArgs e)
{
	// Podmínka která zjišťuje, jestli něco v obrázku je 
	if (new Bitmap(pictureBox1.Image) != null)
	{ 
		/*Zavoláme funkci BlackAndWhite, předáme ji parametry (int,Bitmap) a ta nám zpracuje obrázek (viz. níže)
		* po zpracování vrátí Bitmapu a tu přiřadíme pictureboxu
		*/
		pictureBox2.Image = Grafika.BlackAndWhite(hScrollBar1.Value, new Bitmap(pictureBox1.Image)); 
	}
	else { Warning(); // Zavolá proceduru, která vypíše chybnou hlášku }
}
```
# Kód v hlavním formuláři
## Otevření obrázku
- K otevření obrázku používám **ToolStripButton** a při kliknutí na tento button se otevře dialogové okno, kde vybereme obrázek
- Po vybrání obrázku se obrázek načte do bitmapy a ta je předána pictureBoxu
```C#
// Obslužná metoda události Click
private void open_picture(object sender, EventArgs e)
{
	//Podmínka, která zjistí, jestli jsme něco vybrali
	if(openFileDialog1.ShowDialog() == DialogResult.OK)
	{
	    //inicializuje se nová Bitmapa, které předáme cestu k obrázku a tento obrázek je předán vytvořené bitmapě
	    obr = new Bitmap(openFileDialog1.FileName); 
	    obrPom = new Bitmap(openFileDialog1.FileName);

	    //pictureboxu předáme cestu, ze které načte obrázek (mohlo by to být i takhle pictureBox1.Load(obr);
	    pictureBox1.Load(openFileDialog1.FileName);
	}
}
```
## Uložení obrázku
- Při ukládání obrázku se musí zadat přípona k souboru (např. Obrazek.png)
```C#
void SaveClick(object sender, EventArgs e)
{
	SaveFileDialog sfd = new SaveFileDialog();
	sfd.Filter = "Images|*.png;*.bmp;*.jpg";
	ImageFormat format = ImageFormat.Png;
	if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
	{
		string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
		switch (ext)
		{
			case ".jpg":
				format = ImageFormat.Jpeg;
				break;
			case ".bmp":
				format = ImageFormat.Bmp;
				break;
		}
		pictureBox2.Image.Save(sfd.FileName, format);
	}
}
```

## Kopie po jednotlivých pixelech do form1
- Překopírování obrázku do dalšího formuláře
- Použité prvky: **ToolStripMenuItem**, **Nový formulář form1**
```C#
//K ToolStripMenuItemu sem přiřadil obslužnou metodu události Click
private void kopiePoJednotlivýchPixelech(object sender, EventArgs e)
{
    //Vytvoření instance Form1 a předání parametru (Bitmapa)
    Form1 frm1 = new Form1(obr);
    frm1.Text = "Kopie obrázku po pixelech"; //Nastavuje titulek formuláře
    frm1.Show(this); //Zobrazí formulář
    frm1.Activate(); //Formulář se stane aktivním
}
```
### Kód druhého formuláře
- Na tomto formuláři je ještě kromě bitmapy tlačítko, které po kliknutí načte tento obrázek (s animací jestli se tomu dá tak říkat)
```C#
public partial class Form1 : Form
{
        private Bitmap btm;
        bool mousedown;

        public Form1(Bitmap obr, bool kresleni)
        {
            this.btm = obr; //předání bitmapy
            InitializeComponent();
        }
        
        private void Vykresli()
        {
            Color pixel;
            Bitmap newBtm = new Bitmap(btm.Width,btm.Height);
            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    //získá pixel a nastaví ho v bitmapě na x a y souřadnici
                    pixel = btm.GetPixel(i, j);
                    newBtm.SetPixel(i, j, pixel);         
                }
            pictureBox1.Image = newBtm; //předá bitmapu pictureBoxu
            pictureBox1.Refresh(); //tento příkaz způsobuje "animaci" načítání obrázku do pictureBoxu
            }
    }

    //Obslužná metoda události Click která zavolá proceduru Vykresli
    void Button1Click(object sender, EventArgs e)
    {
        Vykresli();
    }
}
```
## Obdelníkový výřez
- Uživatel si vybere část, kterou chce vyříznout a pak tuto část vyřízne pomocí MenuToolStripItemu 
- Program nejprve uloží počáteční pozici a poté začne vykreslovat obdelník
```C#
//Tyto obslužné metody nám určí, jestli je myš stisknutá a jestlí můžeme vybírat
private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
{
	mousedown = true;
	// Nastavení začátku výběru
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
		    
		    // Zakreslí čtverec/obdelník do pictureboxu (Oblast výběru)
                    grx.DrawLine(pero, bodSpusteni.X, bodSpusteni.Y, e.X, bodSpusteni.Y);
                    grx.DrawLine(pero, e.X, bodSpusteni.Y, e.X, e.Y);
                    grx.DrawLine(pero, e.X, e.Y, bodSpusteni.X, e.Y);
                    grx.DrawLine(pero, bodSpusteni.X, e.Y, bodSpusteni.X, bodSpusteni.Y);
		    
		    //Předáme poslední vybrané souřadnice
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

// Otevře vyříznutý obrázek na novém formuláři
 private void výřezToolStripMenuItem_Click(object sender, EventArgs e)
{
	Bitmap newBtm;
	Color pixel;
	newBtm = new Bitmap(obr.Width*2, obr.Height*2);
	// For Cykly najdou vybranou oblast a projedou ji
	for (int i = bodSpusteni.X+1; i < x; i++)
        {
		for (int j = bodSpusteni.Y+1; j < y; j++)
                {
                    pixel = obr.GetPixel(i, j);
		    // Orázek ještě zvětšuju, aby byl lépe vidět jinak stačí kód nad tímto komentářem
                    newBtm.SetPixel(2 * i, 2 * j, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j, pixel);
                    newBtm.SetPixel(2 * i, 2 * j + 1, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j + 1, pixel);
                }
	}
	// Kód Form1 už byl zmíněn
	Form1 frm1 = new Form1(newBtm, false);
	frm1.Text = "Výřez obrázku";
	frm1.Show(this);
	frm1.Activate();
}
```
## Převedení obrázku do znaků
- Kód převede obrázky do znaků
- U každého pixelu se rozpoznává světlost a podle toho určí, který znak ten pixel nahradí. 
- více zde: https://www.c-sharpcorner.com/article/generating-ascii-art-from-an-image-using-C-Sharp/
```C#
private void KonvertovatObrázekDoZnakůPLSHELPToolStripMenuItemClick(object sender, EventArgs e)
{
        Form frm2 = new Form2();
        frm2.Text = "Převod do ASCII";
	frm2.Show(this);
}
        #endregion
```
### Kód Form2
```C#
	public partial class Form2 : Form
	{
	// Znaky, které nahradí pixely
        private string[] _AsciiChars = { "#", "@", "8", "S", "%", "=", "+", "-", ":", ".", "&nbsp;" };
	private string _Content; // Zde se zapíše převedený obrázek
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

        private void btnConvertToAscii_Click(object sender, EventArgs e)
        {
            btnConvertToAscii.Enabled = false;
            Bitmap image = new Bitmap(txtPath.Text, true);
            image = GetReSizedImage(image, this.trackBar.Value);
            _Content = ConvertToAscii(image);
            browserMain.DocumentText = "<pre>" + "<Font size=0>" + _Content + "</Font></pre>";
            btnConvertToAscii.Enabled = true;
        }
        
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
```
# Kód Knihovní třídy Grafika
- Tento kód si můžete stáhnout z této stránky a jednoduše zaimplementovat do svého projektu
- příklad, jak využít této třídy, máte výše

## Převedení obrázku na černobílý obrázek
- Převede obrázek na černou a bílou s nastavením světlosti z horizontalScrollbaru
- Pro vytvoření černo bílého obrázku potřebujeme zjistit světlost pixelu a podle toho buď nastavit pixel na černý nebo bílý
- Použité prvky: **PictureBox**, **HorizontalScrollbar**, **MenuItemStrip**

```C#
public static Bitmap BlackAndWhite(int ScrollBarValue, Bitmap image)
{
	obr = new Bitmap(image);
	for (int i = 0; i < obr.Width; i++)
	{
		for (int j = 0; j < obr.Height; j++)
		{
			// Získání barvy pixelu
			Color pixel = obr.GetPixel(i, j);
			
			// Získání jednotlivé hodnoty pixelu
			red = pixel.R;
			green = pixel.G;
			blue = pixel.B;
			
			//Získání světlosti
			svetlost = (red * podR + green * podG + blue * podB);
			
			/*Podmínka, kteráporovnává jestli hodnota Svetlost je menší než hodnota HScrollBaru a podle toho
                	* se nastaví buď černá nebo bílá barva
                	*/
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
```
## Otočení obrázku o 90°
- Otočí obrázek o 90° (Nevím co k tomu víc napsat je to celkem jednoduchý :) )
```C#
obr.RotateFlip(RotateFlipType.Rotate90FlipNone);
```

## Převedení obrázku na obrys
- Funkce porovná světlost pixelu se sousedícím pixelem a podle toho rozhodne, jestli se pixel zakreslí nebo ne
- Potřebné prvky: **MenuStripItem**,**PictureBox**

```C#
public static Bitmap Obrys(Bitmap image)
{
	obr = new Bitmap(image); // Předání parametru Bitmapě
	for (int i = 0; i < obr.Width; i++)
	{
		for (int j = 0; j < obr.Height; j++)
		{
			// Získání barvy pixelu a vypočítaní její světlosti
			pixel = obr.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;
                        starasvetlost = (red * podR + green * podG + blue * podB);
			
			//Podmínka, která zjišťuje jestli vedlejší pixel není mimo hranici bitmapy
                        if ((i < obr.Width - 1)&&(j < obr.Height - 1))
                        {
				// Získání barvy pixelu a vypočítaní její světlosti
				pixel = obr.GetPixel(i + 1, j + 1);
				red = pixel.R;
				green = pixel.G;
				blue = pixel.B;
				svetlost = (red * podR + green * podG + blue * podB);
                        }
			/* Podmínka, která vypočítá rozdíl světlosti vybraného a sousedícího pixelu a převede ji na absolutní hodnotu 
			* Do podmínky by se mohla i teoreticky dát hodnota Scrollbaru
			*/
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
	return obr; //Vrácení hodnoty hlavní třídě
}
```

## Zvětšení obrázku 2x
- Každý pixel se přepíše na novou bitmapu zapíše 4krát

```C#
public static Bitmap Zvětšení(Bitmap image)
{
	obr = image;
	Bitmap obrn; //bitmapa, která bude použita na zvětšení
	obrn = new Bitmap(obr.Width*2, obr.Height*2);
	for (int i = 0; i < obr.Width; i++)
	{
		for (int j = 0; j < obr.Height; j++)
		{
			Color pixel = obr.GetPixel(i, j);
			//Každý pixel se zapíše do sousedícího pixelu
                        obrn.SetPixel(2 * i, 2 * j, pixel);
                        obrn.SetPixel(2 * i + 1, 2 * j, pixel);
                        obrn.SetPixel(2 * i, 2 * j + 1, pixel);
                        obrn.SetPixel(2 * i + 1, 2 * j + 1, pixel);
		}
	}
	return obrn;
}
```
## Reliéf	
- Porovnání světlosti
```C#
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
```
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
