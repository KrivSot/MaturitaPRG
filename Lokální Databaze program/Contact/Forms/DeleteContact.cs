using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using Kribo.Class;

namespace Kribo.Forms
{
    public partial class DeleteContact : BaseContact
    {
        private Boolean deleteSucces;
        private Int32 contactId;
        private dBHelper helper = null;
        private DataRow dataRow = null;

        public DeleteContact(Boolean i, Int32 j)
        {
            InitializeComponent();
            base.buttonLeft.Text = "Cancel";
            base.buttonRight.Text = "OK";
            base.textBoxFName.Enabled = false;
            base.textBoxLName.Enabled = false;
            deleteSucces = i;
            contactId = j;
        }
        public Boolean GetDeleteSucces()
        {
            return deleteSucces;
        }

        private void DeleteContact_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            // Determin the ConnectionString
            string connectionString = dBFunctions.ConnectionStringSQLite;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = @"SELECT * FROM Contact WHERE contact_id =" + contactId;

            // Make a new object
            helper = new dBHelper(connectionString);

            // Load the data
            if (helper.Load(commandText, "") == true)
            {
                // Show the data in the datagridview
                dataRow = helper.DataSet.Tables[0].Rows[0];
                base.textBoxId.Text = dataRow[0].ToString();
                base.textBoxFName.Text = dataRow[1].ToString();
                base.textBoxLName.Text = dataRow[2].ToString();
            }
        }

        private void buttonLeft_Click_1(object sender, EventArgs e)
        {
            // button Cancel
            this.Close();
        }

        private void buttonRight_Click_1(object sender, EventArgs e)
        {
            // button Delete
            // Determin the ConnectionString
            string connectionString = dBFunctions.ConnectionStringSQLite;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = "SELECT * FROM Contact WHERE contact_id=" + contactId;

            // Make a new object
            helper = new dBHelper(connectionString);
            {
                // Load Data
                if (helper.Load(commandText, "contact_id") == true)
                {
                    // Determin if the row was found
                    if (helper.DataSet.Tables[0].Rows.Count == 1)
                    {
                        // Found, delete row
                        helper.DataSet.Tables[0].Rows[0].Delete();
                        try
                        {
                            // Save -> determin succes
                            if (helper.Save() == true)
                            {
                                deleteSucces = true;
                                MessageBox.Show("Delete succesfull");
                                this.Close();
                            }
                            else
                            {
                                deleteSucces = false;
                                MessageBox.Show("Delete failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show the Exception --> Dubbel ContactId/Name ?
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }

        }
    }
}
