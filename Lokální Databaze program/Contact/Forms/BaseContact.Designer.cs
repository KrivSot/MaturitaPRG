namespace Kribo.Forms
{
    partial class BaseContact
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
            this.components = new System.ComponentModel.Container();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderBaseId = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseId)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(23, 118);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "button1";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(110, 118);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "button2";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(85, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(85, 43);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(85, 69);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // errorProviderBaseId
            // 
            this.errorProviderBaseId.ContainerControl = this;
            // 
            // BaseContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 181);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLeft);
            this.Name = "BaseContact";
            this.Text = "BaseContact";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBoxId;
        protected System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button buttonRight;
        protected System.Windows.Forms.ErrorProvider errorProviderBaseId;
    }
}