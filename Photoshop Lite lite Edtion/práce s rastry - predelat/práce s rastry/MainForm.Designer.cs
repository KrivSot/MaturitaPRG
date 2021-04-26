/*
 * Created by SharpDevelop.
 * User: cejchank
 * Date: 30.01.2019
 * Time: 8:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace práce_s_rastry
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
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripMenuItem jednoduchéOperaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kopiePoPixeluToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripMenuItem blackWhiteToolStripMenuItem;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.ToolStripMenuItem obrysyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odstínůŠediToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem kresleníPeremToolStripMenuItem;
		
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
			this.blackWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrysyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odstínůŠediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kresleníPeremToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jednoduchéOperaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kopiePoPixeluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			this.menuStrip1.Size = new System.Drawing.Size(705, 24);
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
			this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.OtevřítToolStripMenuItemClick);
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
			this.zavřítToolStripMenuItem.Click += new System.EventHandler(this.ZavřítToolStripMenuItemClick);
			// 
			// práceSObrázkemToolStripMenuItem
			// 
			this.práceSObrázkemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.blackWhiteToolStripMenuItem,
			this.obrysyToolStripMenuItem,
			this.odstínůŠediToolStripMenuItem,
			this.zoomInToolStripMenuItem,
			this.kresleníPeremToolStripMenuItem});
			this.práceSObrázkemToolStripMenuItem.Name = "práceSObrázkemToolStripMenuItem";
			this.práceSObrázkemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.práceSObrázkemToolStripMenuItem.Text = "Nástroje";
			// 
			// blackWhiteToolStripMenuItem
			// 
			this.blackWhiteToolStripMenuItem.Name = "blackWhiteToolStripMenuItem";
			this.blackWhiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.blackWhiteToolStripMenuItem.Text = "Black&White";
			this.blackWhiteToolStripMenuItem.Click += new System.EventHandler(this.BlackWhiteToolStripMenuItemClick);
			// 
			// obrysyToolStripMenuItem
			// 
			this.obrysyToolStripMenuItem.Name = "obrysyToolStripMenuItem";
			this.obrysyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.obrysyToolStripMenuItem.Text = "Obrysy";
			this.obrysyToolStripMenuItem.Click += new System.EventHandler(this.ObrysyToolStripMenuItemClick);
			// 
			// odstínůŠediToolStripMenuItem
			// 
			this.odstínůŠediToolStripMenuItem.Name = "odstínůŠediToolStripMenuItem";
			this.odstínůŠediToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.odstínůŠediToolStripMenuItem.Text = "50 odstínů šedi";
			this.odstínůŠediToolStripMenuItem.Click += new System.EventHandler(this.OdstínůŠediToolStripMenuItemClick);
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.zoomInToolStripMenuItem.Text = "Zoom in";
			this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInToolStripMenuItemClick);
			// 
			// kresleníPeremToolStripMenuItem
			// 
			this.kresleníPeremToolStripMenuItem.Name = "kresleníPeremToolStripMenuItem";
			this.kresleníPeremToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.kresleníPeremToolStripMenuItem.Text = "Kreslení perem";
			this.kresleníPeremToolStripMenuItem.Click += new System.EventHandler(this.KresleníPeremToolStripMenuItemClick);
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
			this.kopiePoPixeluToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem2,
			this.toolStripMenuItem3,
			this.toolStripMenuItem4});
			this.kopiePoPixeluToolStripMenuItem.Name = "kopiePoPixeluToolStripMenuItem";
			this.kopiePoPixeluToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.kopiePoPixeluToolStripMenuItem.Text = "Kopie po pixelu";
			this.kopiePoPixeluToolStripMenuItem.Click += new System.EventHandler(this.KopiePoPixeluToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItem2.Text = "90";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItem3.Text = "180";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItem4.Text = "270";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(12, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(307, 296);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseUp);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripLabel1,
			this.toolStripButton3,
			this.toolStripButton1,
			this.toolStripSeparator1,
			this.toolStripButton4,
			this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(705, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
			this.toolStripLabel1.Text = "Zkratky:";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "Open file...";
			this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Save the project";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "Dark mode";
			this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "Exit";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Location = new System.Drawing.Point(369, 90);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(307, 296);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseDown);
			this.pictureBox2.MouseEnter += new System.EventHandler(this.PictureBox2MouseEnter);
			this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2MouseLeave);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseMove);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(456, 408);
			this.hScrollBar1.Maximum = 255;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(171, 17);
			this.hScrollBar1.SmallChange = 10;
			this.hScrollBar1.TabIndex = 4;
			this.hScrollBar1.Value = 125;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.HScrollBar1ValueChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(705, 484);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "práce s rastry";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
