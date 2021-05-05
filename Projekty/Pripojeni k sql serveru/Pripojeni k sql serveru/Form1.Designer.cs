/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 24.02.2021
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pripojeni_k_sql_serveru
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox JmenoTextBox;
		private System.Windows.Forms.TextBox PrijmeniTextBox;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.JmenoTextBox = new System.Windows.Forms.TextBox();
			this.PrijmeniTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Jmeno";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Prijmeni";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(52, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Přidat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.PřidatData);
			// 
			// JmenoTextBox
			// 
			this.JmenoTextBox.Location = new System.Drawing.Point(63, 32);
			this.JmenoTextBox.Name = "JmenoTextBox";
			this.JmenoTextBox.Size = new System.Drawing.Size(100, 20);
			this.JmenoTextBox.TabIndex = 5;
			// 
			// PrijmeniTextBox
			// 
			this.PrijmeniTextBox.Location = new System.Drawing.Point(63, 58);
			this.PrijmeniTextBox.Name = "PrijmeniTextBox";
			this.PrijmeniTextBox.Size = new System.Drawing.Size(100, 20);
			this.PrijmeniTextBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 198);
			this.Controls.Add(this.PrijmeniTextBox);
			this.Controls.Add(this.JmenoTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
