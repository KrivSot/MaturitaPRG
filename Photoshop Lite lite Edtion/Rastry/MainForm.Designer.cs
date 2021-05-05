/*
 * Created by SharpDevelop.
 * User: ivanchov
 * Date: 30.01.2019
 * Time: 8:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rastry
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem práceSObrázkemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem zavřítToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uložitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.zavřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.práceSObrázkemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackandWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.šeďToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zvětšeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.úpravaBarevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kresleníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kopiePoJednotlivýchPixelechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.výřezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nahrazeníBarvyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reliéfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jednoduchéOperaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kopiePoPixeluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label3 = new System.Windows.Forms.Label();
			this.RtrackBar = new System.Windows.Forms.TrackBar();
			this.GtrackBar = new System.Windows.Forms.TrackBar();
			this.BtrackBar = new System.Windows.Forms.TrackBar();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.souborToolStripMenuItem,
			this.práceSObrázkemToolStripMenuItem,
			this.jednoduchéOperaceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(935, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// souborToolStripMenuItem
			// 
			this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.otevřítToolStripMenuItem,
			this.uložitToolStripMenuItem,
			this.uložitToolStripMenuItem1,
			this.zavřítToolStripMenuItem});
			this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
			this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.souborToolStripMenuItem.Text = "&Soubor";
			// 
			// otevřítToolStripMenuItem
			// 
			this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
			this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.otevřítToolStripMenuItem.Text = "&Otevřít";
			this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.Otevřít_obrázek);
			// 
			// uložitToolStripMenuItem
			// 
			this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
			this.uložitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.uložitToolStripMenuItem.Text = "&Nový";
			// 
			// uložitToolStripMenuItem1
			// 
			this.uložitToolStripMenuItem1.Name = "uložitToolStripMenuItem1";
			this.uložitToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
			this.uložitToolStripMenuItem1.Text = "&Uložit";
			// 
			// zavřítToolStripMenuItem
			// 
			this.zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
			this.zavřítToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.zavřítToolStripMenuItem.Text = "&Zavřít";
			// 
			// práceSObrázkemToolStripMenuItem
			// 
			this.práceSObrázkemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.negativToolStripMenuItem,
			this.blackandWhiteToolStripMenuItem,
			this.obrysToolStripMenuItem,
			this.šeďToolStripMenuItem,
			this.zvětšeníToolStripMenuItem,
			this.úpravaBarevToolStripMenuItem,
			this.kresleníToolStripMenuItem,
			this.kopiePoJednotlivýchPixelechToolStripMenuItem,
			this.výřezToolStripMenuItem,
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem,
			this.nahrazeníBarvyToolStripMenuItem,
			this.reliéfToolStripMenuItem});
			this.práceSObrázkemToolStripMenuItem.Name = "práceSObrázkemToolStripMenuItem";
			this.práceSObrázkemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.práceSObrázkemToolStripMenuItem.Text = "Nástroje";
			// 
			// negativToolStripMenuItem
			// 
			this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
			this.negativToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.negativToolStripMenuItem.Text = "Negativ";
			this.negativToolStripMenuItem.Click += new System.EventHandler(this.NegativToolStripMenuItemClick);
			// 
			// blackandWhiteToolStripMenuItem
			// 
			this.blackandWhiteToolStripMenuItem.Name = "blackandWhiteToolStripMenuItem";
			this.blackandWhiteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.blackandWhiteToolStripMenuItem.Text = "BlackandWhite";
			this.blackandWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackandWhite);
			// 
			// obrysToolStripMenuItem
			// 
			this.obrysToolStripMenuItem.Name = "obrysToolStripMenuItem";
			this.obrysToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.obrysToolStripMenuItem.Text = "Obrys";
			this.obrysToolStripMenuItem.Click += new System.EventHandler(this.Obrys);
			// 
			// šeďToolStripMenuItem
			// 
			this.šeďToolStripMenuItem.Name = "šeďToolStripMenuItem";
			this.šeďToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.šeďToolStripMenuItem.Text = "Šeď";
			this.šeďToolStripMenuItem.Click += new System.EventHandler(this.šeď);
			// 
			// zvětšeníToolStripMenuItem
			// 
			this.zvětšeníToolStripMenuItem.Name = "zvětšeníToolStripMenuItem";
			this.zvětšeníToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.zvětšeníToolStripMenuItem.Text = "Zvětšení";
			this.zvětšeníToolStripMenuItem.Click += new System.EventHandler(this.zvětšení_obrázku);
			// 
			// úpravaBarevToolStripMenuItem
			// 
			this.úpravaBarevToolStripMenuItem.Name = "úpravaBarevToolStripMenuItem";
			this.úpravaBarevToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.úpravaBarevToolStripMenuItem.Text = "Úprava Barev";
			// 
			// kresleníToolStripMenuItem
			// 
			this.kresleníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.peroToolStripMenuItem,
			this.gumaToolStripMenuItem});
			this.kresleníToolStripMenuItem.Name = "kresleníToolStripMenuItem";
			this.kresleníToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.kresleníToolStripMenuItem.Text = "Kreslení";
			// 
			// peroToolStripMenuItem
			// 
			this.peroToolStripMenuItem.Name = "peroToolStripMenuItem";
			this.peroToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.peroToolStripMenuItem.Text = "pero";
			this.peroToolStripMenuItem.Click += new System.EventHandler(this.PeroToolStripMenuItemClick);
			// 
			// gumaToolStripMenuItem
			// 
			this.gumaToolStripMenuItem.Name = "gumaToolStripMenuItem";
			this.gumaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.gumaToolStripMenuItem.Text = "guma";
			// 
			// kopiePoJednotlivýchPixelechToolStripMenuItem
			// 
			this.kopiePoJednotlivýchPixelechToolStripMenuItem.Name = "kopiePoJednotlivýchPixelechToolStripMenuItem";
			this.kopiePoJednotlivýchPixelechToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.kopiePoJednotlivýchPixelechToolStripMenuItem.Text = "Kopie po jednotlivých pixelech";
			this.kopiePoJednotlivýchPixelechToolStripMenuItem.Click += new System.EventHandler(this.kopiePoJednotlivýchPixelech);
			// 
			// výřezToolStripMenuItem
			// 
			this.výřezToolStripMenuItem.Name = "výřezToolStripMenuItem";
			this.výřezToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.výřezToolStripMenuItem.Text = "Výřez";
			this.výřezToolStripMenuItem.Click += new System.EventHandler(this.výřezToolStripMenuItem_Click);
			// 
			// konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem
			// 
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem.Name = "konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem";
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem.Text = "Konvertovat obrázek do znaků";
			this.konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem.Click += new System.EventHandler(this.KonvertovatObrázekDoZnakůPLSHELPToolStripMenuItemClick);
			// 
			// nahrazeníBarvyToolStripMenuItem
			// 
			this.nahrazeníBarvyToolStripMenuItem.Name = "nahrazeníBarvyToolStripMenuItem";
			this.nahrazeníBarvyToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.nahrazeníBarvyToolStripMenuItem.Text = "Nahrazení barvy";
			this.nahrazeníBarvyToolStripMenuItem.Click += new System.EventHandler(this.NahrazeníBarvyToolStripMenuItemClick);
			// 
			// reliéfToolStripMenuItem
			// 
			this.reliéfToolStripMenuItem.Name = "reliéfToolStripMenuItem";
			this.reliéfToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.reliéfToolStripMenuItem.Text = "Reliéf";
			this.reliéfToolStripMenuItem.Click += new System.EventHandler(this.ReliéfToolStripMenuItemClick);
			// 
			// jednoduchéOperaceToolStripMenuItem
			// 
			this.jednoduchéOperaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.kopiePoPixeluToolStripMenuItem});
			this.jednoduchéOperaceToolStripMenuItem.Name = "jednoduchéOperaceToolStripMenuItem";
			this.jednoduchéOperaceToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
			this.jednoduchéOperaceToolStripMenuItem.Text = "Jednoduché operace";
			// 
			// kopiePoPixeluToolStripMenuItem
			// 
			this.kopiePoPixeluToolStripMenuItem.Name = "kopiePoPixeluToolStripMenuItem";
			this.kopiePoPixeluToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.kopiePoPixeluToolStripMenuItem.Text = "Kopie po pixelu";
			this.kopiePoPixeluToolStripMenuItem.Click += new System.EventHandler(this.kopiePoPixeluToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(47, 94);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(271, 338);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Obrázek|*.jpg|Bitmapa|*.gmp|Všechny soubory|*.*";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newToolStripButton,
			this.openToolStripButton,
			this.saveToolStripButton,
			this.printToolStripButton,
			this.toolStripSeparator,
			this.cutToolStripButton,
			this.copyToolStripButton,
			this.pasteToolStripButton,
			this.toolStripSeparator1,
			this.helpToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(935, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "&New";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			this.openToolStripButton.Click += new System.EventHandler(this.open_picture);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name = "cutToolStripButton";
			this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text = "C&ut";
			this.cutToolStripButton.Click += new System.EventHandler(this.CutToolStripButtonClick);
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(397, 94);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(346, 338);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseDown);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseMove);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Do tohoto okna se otevře původní obrázek";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(394, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(274, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Do tohoto okna můžete kreslit pomocí nástrojů - kreslení";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.LargeChange = 1;
			this.hScrollBar1.Location = new System.Drawing.Point(433, 49);
			this.hScrollBar1.Maximum = 255;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(171, 17);
			this.hScrollBar1.TabIndex = 6;
			this.hScrollBar1.Value = 120;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.HScrollBar1ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(502, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "120";
			// 
			// RtrackBar
			// 
			this.RtrackBar.Location = new System.Drawing.Point(397, 438);
			this.RtrackBar.Maximum = 255;
			this.RtrackBar.Name = "RtrackBar";
			this.RtrackBar.Size = new System.Drawing.Size(104, 45);
			this.RtrackBar.TabIndex = 8;
			this.RtrackBar.Scroll += new System.EventHandler(this.ZmenaBarev);
			// 
			// GtrackBar
			// 
			this.GtrackBar.Location = new System.Drawing.Point(507, 438);
			this.GtrackBar.Maximum = 255;
			this.GtrackBar.Name = "GtrackBar";
			this.GtrackBar.Size = new System.Drawing.Size(104, 45);
			this.GtrackBar.TabIndex = 9;
			this.GtrackBar.Scroll += new System.EventHandler(this.ZmenaBarev);
			// 
			// BtrackBar
			// 
			this.BtrackBar.Location = new System.Drawing.Point(620, 438);
			this.BtrackBar.Maximum = 255;
			this.BtrackBar.Name = "BtrackBar";
			this.BtrackBar.Size = new System.Drawing.Size(104, 45);
			this.BtrackBar.TabIndex = 10;
			this.BtrackBar.Scroll += new System.EventHandler(this.ZmenaBarev);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 606);
			this.Controls.Add(this.BtrackBar);
			this.Controls.Add(this.GtrackBar);
			this.Controls.Add(this.RtrackBar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Rastry";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem jednoduchéOperaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiePoPixeluToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackandWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem šeďToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiePoJednotlivýchPixelechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kresleníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem úpravaBarevToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem obrysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvětšeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výřezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konvertovatObrázekDoZnakůPLSHELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nahrazeníBarvyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reliéfToolStripMenuItem;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TrackBar BtrackBar;
	}
}
