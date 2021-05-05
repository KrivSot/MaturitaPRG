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
```
# Otevření obrázku
- K otevření obrázku používám **ToolStripButton** a při kliknutí na tento button se otevře dialogové okno, kde vybereme obrázek
- Po vybrání obrázku se obrázek načte do bitmapy a ta je předána pictureBoxu
```C#
//Podmínka, která zjistí, jestli jsme něco vybrali
if(openFileDialog1.ShowDialog() == DialogResult.OK)
{
    //inicializuje se nová Bitmapa, které předáme cestu k obrázku a tento obrázek je předán vytvořené bitmapě
    obr = new Bitmap(openFileDialog1.FileName); 
    obrPom = new Bitmap(openFileDialog1.FileName);
    
    //pictureboxu předáme cestu, ze které načte obrázek (mohlo by to být i takhle pictureBox1.Load(obr);
    pictureBox1.Load(openFileDialog1.FileName);
}
```

# Kopie po jednotlivých pixelech do form1
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
## Kód druhého formuláře
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

# Převedení obrázku na černobílý obrázek
- Převede obrázek na černou a bílou s nastavením světlosti z horizontalScrollbaru
- Pro vytvoření černo bílého obrázku potřebujeme zjistit světlost pixelu a podle toho buď nastavit pixel na černý nebo bílý
- Použité prvky: **PictureBox**, **HorizontalScrollbar**, **MenuItemStrip**

```C#
// Obslužná metoda události Click pro MenuStripItem
private void blackandWhite(object sender, EventArgs e)
{
    //pro vytvoření černo bílého obrázku potřebujeme zjistit světlost pixelu
    //pixel je barva skládající se ze tří barev
    //nejvíce se na světlosti podílí zelená barva (cca. 60%[58.66%]) [modrá: 11%(11.45%) červená: 29.89%(30%)]
    obr = new Bitmap(pictureBox1.Image);
    if (obr != null)
    {
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
                //obr.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(svetlost), Convert.ToInt32(svetlost), Convert.ToInt32(svetlost))); //- lepší černo bílý obrázek
                
                /*Podmínka, kteráporovnává jestli hodnota Svetlost je menší než hodnota HScrollBaru a podle toho
                * se nastaví buď černá nebo bílá barva
                */
                if (svetlost < hScrollBar1.Value)
                {
                    obr.SetPixel(i, j, Color.Black);
                }
                else
                {
                    obr.SetPixel(i, j, Color.White);
                }
            }
        }
                pictureBox2.Image = obr;
    }
    else { Warning(); } //Zavolá proceduru, která vypíše chybnou hlášku
}
```
# Otočení obrázku o 90°
- Otočí obrázek o 90° (Nevím co k tomu víc napsat je to celkem jednoduchý :) )
```C#
obr.RotateFlip(RotateFlipType.Rotate90FlipNone);
```
# Převedení obrázku na obrys
- Funkce porovná světlost pixelu se sousedícím pixelem a podle toho rozhodne, jestli se pixel zakreslí nebo ne
- Potřebné prvky: **MenuStripItem**,**PictureBox**
```C#
// Obslužná metoda události Click pro MenuStripItem
void Obrys(object sender, EventArgs e)
{
	Color pixel;
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
	pictureBox2.Image = obr;
}
```
