V tomto repositáři naleznete kód, který pracuje s grafikou

# Důležité proměnné

```C#
private static Bitmap obr; // Bitmapa do které uložíme upravený obrázek
private static Bitmap obrPom; //Bitmapa neupraveného obrázku

/* Tyto tři hodnoty nám pomůžou s konvertováním obrázku na stupně šedi
* Je to vlastně počet v procentech, jak moc se určitá barva podílí na světlosti
*/
private static decimal podR = 0.2989M; 
private static decimal podG = 0.5866M;
private static decimal podB = 0.1145M;
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
