/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 06.05.2019
 * Time: 7:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace databaze
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 103);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(429, 417);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UkažRelaci);
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UkažJméno);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(636, 103);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(429, 417);
			this.dataGridView2.TabIndex = 1;
			this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UkažJménoP);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1,
			this.toolStripButton2,
			this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1097, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.PridatData);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.Click += new System.EventHandler(this.SmazatData);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
			"Jmeno",
			"Prijmeni",
			"Obec",
			"Ulice",
			"cislo_popisne",
			"PSC"});
			this.listBox1.Location = new System.Drawing.Point(657, 28);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(99, 43);
			this.listBox1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(185, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Vyhledávač";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(267, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(352, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.Vyhledávač);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(539, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Co vyhledáváte:";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(265, 66);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Osoby";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.VaEOsob);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(375, 66);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Psi";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.VaEPsu);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Items.AddRange(new object[] {
			"Jmeno",
			"Osoba_ID",
			"Narozen"});
			this.listBox2.Location = new System.Drawing.Point(657, 28);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(99, 43);
			this.listBox2.TabIndex = 10;
			this.listBox2.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(68, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Kde vyhledávát + co se bude editovat:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1097, 542);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "databaze";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Click += new System.EventHandler(this.MainFormClick);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
	}
}
