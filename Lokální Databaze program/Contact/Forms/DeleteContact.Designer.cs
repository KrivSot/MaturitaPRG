namespace Kribo.Forms
{
    partial class DeleteContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseId)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click_1);
            // 
            // buttonRight
            // 
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click_1);
            // 
            // DeleteContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 181);
            this.Name = "DeleteContact";
            this.Text = "DeleteContact";
            this.Load += new System.EventHandler(this.DeleteContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}