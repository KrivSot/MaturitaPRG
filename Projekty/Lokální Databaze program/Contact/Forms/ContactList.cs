using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Kribo.Class;

namespace Kribo.Forms
{
    public partial class ContactList : Form
    {
        private dBHelper helper = null;
        private Boolean NewContactInsert = false;
        private Boolean NewContactEdit = false;
        private Boolean NewContactDelete = false;


        public ContactList()
        {
            InitializeComponent();
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            GetData();
            FillData();
        }
        
        private void GetData()
        {
            // Determin the ConnectionString
            string connectionString = dBFunctions.ConnectionStringSQLite;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = @"SELECT * FROM Contact ORDER BY contact_id";

            // Make a new object
            helper = new dBHelper(connectionString);

            // Load the data
            if (helper.Load(commandText, "") == true)
            {
                // Show the data in the datagridview
                dataGridViewContactList.DataSource = helper.DataSet.Tables[0];
                listBox1.ValueMember= "FirstName";
    			listBox1.DisplayMember="FirstName";
                listBox1.DataSource = helper.DataSet;
            }
        }
        
        void FillData()
        {
        	string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\Contact.s3db";
            string conString =  @"Data Source=" + Path.GetFullPath(database);
                   
        
	        using (SQLiteConnection c = new SQLiteConnection(conString)) 
	        {
	            c.Open();
				//SQLiteDataAdapter sda = new SQLiteDataAdapter(c.CreateCommand());
                using (SQLiteDataAdapter a = new SQLiteDataAdapter("SELECT * FROM Contact ORDER BY contact_id", c))
                {            
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    // Bind the table to the list box
                    listBox1.DisplayMember = "FirstName";
                    listBox1.ValueMember = "FirstName";
                    listBox1.DataSource = t;
                }
                using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read()) {
                lb.Items.Add(new ListItem((string)reader["column"]));
            }
        }
            }
        }

        /// <summary>
        /// Needs revision is this still required ?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Do something on double click, except when on the header.
            if (e.RowIndex == -1)
            {
                return;
            }
            // Have aquired a valided row
            UpdateSidePannel();
        }
        private void UpdateSidePannel()
        {
            Int32 i = Convert.ToInt32(dataGridViewContactList.CurrentRow.Cells[0].Value);
            DataRow dataRow = helper.DataSet.Tables[0].Rows[i - 1];
            MessageBox.Show(dataRow[1].ToString() + ' ' + dataRow[2].ToString());
        }

        
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            RunNewContact();
        }
        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            RunEditContact();
        }
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            RunDeleteContact();
        }
        


        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            RunNewContact();
        }
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            RunEditContact();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            RunDeleteContact();
        }

        
        public NewContact newContact;
        private void RunNewContact()
        {
            if (newContact == null || newContact.IsDisposed)
            {
                newContact = new NewContact(NewContactInsert);
                newContact.ShowDialog();
                newContact.Dispose();
                NewContactInsert = newContact.GetInsertSucces();
            }
            else
            {
                newContact.Activate();
            }
            if (NewContactInsert == true)
            {
                GetData();
                NewContactInsert = false;
            }

        }

        public EditContact editContact;
        private void RunEditContact()
        {
            Int32 i = Convert.ToInt32(dataGridViewContactList.CurrentRow.Cells[0].Value);
            if (editContact == null || editContact.IsDisposed)
            {
                editContact = new EditContact(NewContactEdit, i);
                editContact.ShowDialog();
                editContact.Dispose();
                NewContactEdit = editContact.GetEditSucces();
            }
            else
            {
                editContact.Activate();
            }
            if (NewContactEdit == true)
            {
                GetData();
                NewContactEdit = false;
            }
        }

        public DeleteContact deleteContact;
        private void RunDeleteContact()
        {
            Int32 i = Convert.ToInt32(dataGridViewContactList.CurrentRow.Cells[0].Value);
            if (deleteContact == null || deleteContact.IsDisposed)
            {
                deleteContact = new DeleteContact(NewContactDelete, i);
                deleteContact.ShowDialog();
                deleteContact.Dispose();
                NewContactDelete = deleteContact.GetDeleteSucces();
            }
            else
            {
                deleteContact.Activate();
            }
            if (NewContactDelete == true)
            {
                GetData();
                NewContactDelete = false;
            }
        }
		void BindingSourceContactListCurrentChanged(object sender, EventArgs e)
		{
	
		}







    }
}
