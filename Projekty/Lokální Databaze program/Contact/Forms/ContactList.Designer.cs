namespace Kribo.Forms
{
    partial class ContactList
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactList));
        	this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
        	this.contextMenuStripDataGridViewContactList = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
        	this.bindingSourceContactList = new System.Windows.Forms.BindingSource(this.components);
        	this.dataView1 = new System.Data.DataView();
        	this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        	this.toolStripContainer2.ContentPanel.SuspendLayout();
        	this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
        	this.toolStripContainer2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).BeginInit();
        	this.contextMenuStripDataGridViewContactList.SuspendLayout();
        	this.toolStrip1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.bindingSourceContactList)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// toolStripContainer2
        	// 
        	// 
        	// toolStripContainer2.ContentPanel
        	// 
        	this.toolStripContainer2.ContentPanel.Controls.Add(this.listBox1);
        	this.toolStripContainer2.ContentPanel.Controls.Add(this.dataGridViewContactList);
        	this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(620, 502);
        	this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
        	this.toolStripContainer2.Name = "toolStripContainer2";
        	this.toolStripContainer2.Size = new System.Drawing.Size(620, 527);
        	this.toolStripContainer2.TabIndex = 9;
        	this.toolStripContainer2.Text = "toolStripContainer2";
        	// 
        	// toolStripContainer2.TopToolStripPanel
        	// 
        	this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
        	// 
        	// listBox1
        	// 
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.Location = new System.Drawing.Point(62, 320);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(527, 95);
        	this.listBox1.TabIndex = 1;
        	// 
        	// dataGridViewContactList
        	// 
        	this.dataGridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridViewContactList.ContextMenuStrip = this.contextMenuStripDataGridViewContactList;
        	this.dataGridViewContactList.Location = new System.Drawing.Point(0, 0);
        	this.dataGridViewContactList.Name = "dataGridViewContactList";
        	this.dataGridViewContactList.ReadOnly = true;
        	this.dataGridViewContactList.Size = new System.Drawing.Size(675, 292);
        	this.dataGridViewContactList.TabIndex = 0;
        	this.dataGridViewContactList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactList_CellDoubleClick);
        	// 
        	// contextMenuStripDataGridViewContactList
        	// 
        	this.contextMenuStripDataGridViewContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemNew,
			this.toolStripMenuItemEdit,
			this.toolStripMenuItemDelete});
        	this.contextMenuStripDataGridViewContactList.Name = "contextMenuStripDataGridViewContactList";
        	this.contextMenuStripDataGridViewContactList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        	this.contextMenuStripDataGridViewContactList.ShowCheckMargin = true;
        	this.contextMenuStripDataGridViewContactList.Size = new System.Drawing.Size(130, 70);
        	// 
        	// toolStripMenuItemNew
        	// 
        	this.toolStripMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNew.Image")));
        	this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
        	this.toolStripMenuItemNew.Size = new System.Drawing.Size(129, 22);
        	this.toolStripMenuItemNew.Text = "New";
        	this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
        	// 
        	// toolStripMenuItemEdit
        	// 
        	this.toolStripMenuItemEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEdit.Image")));
        	this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
        	this.toolStripMenuItemEdit.Size = new System.Drawing.Size(129, 22);
        	this.toolStripMenuItemEdit.Text = "Edit";
        	this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
        	// 
        	// toolStripMenuItemDelete
        	// 
        	this.toolStripMenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDelete.Image")));
        	this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
        	this.toolStripMenuItemDelete.Size = new System.Drawing.Size(129, 22);
        	this.toolStripMenuItemDelete.Text = "Delete";
        	this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
        	// 
        	// toolStrip1
        	// 
        	this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
        	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButtonNew,
			this.toolStripButtonEdit,
			this.toolStripButtonDelete});
        	this.toolStrip1.Location = new System.Drawing.Point(3, 0);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        	this.toolStrip1.Size = new System.Drawing.Size(81, 25);
        	this.toolStrip1.TabIndex = 7;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// toolStripButtonNew
        	// 
        	this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
        	this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonNew.Name = "toolStripButtonNew";
        	this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonNew.Text = "New";
        	this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
        	// 
        	// toolStripButtonEdit
        	// 
        	this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
        	this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonEdit.Name = "toolStripButtonEdit";
        	this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonEdit.Text = "Edit";
        	this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
        	// 
        	// toolStripButtonDelete
        	// 
        	this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
        	this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonDelete.Name = "toolStripButtonDelete";
        	this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonDelete.Text = "Delete";
        	this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
        	// 
        	// bindingSourceContactList
        	// 
        	this.bindingSourceContactList.CurrentChanged += new System.EventHandler(this.BindingSourceContactListCurrentChanged);
        	// 
        	// ContactList
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(620, 527);
        	this.Controls.Add(this.toolStripContainer2);
        	this.Name = "ContactList";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "cc";
        	this.Load += new System.EventHandler(this.ContactList_Load);
        	this.toolStripContainer2.ContentPanel.ResumeLayout(false);
        	this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
        	this.toolStripContainer2.TopToolStripPanel.PerformLayout();
        	this.toolStripContainer2.ResumeLayout(false);
        	this.toolStripContainer2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).EndInit();
        	this.contextMenuStripDataGridViewContactList.ResumeLayout(false);
        	this.toolStrip1.ResumeLayout(false);
        	this.toolStrip1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.bindingSourceContactList)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.BindingSource bindingSourceContactList;
        private System.Windows.Forms.DataGridView dataGridViewContactList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewContactList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Data.DataView dataView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBox1;
    }
}