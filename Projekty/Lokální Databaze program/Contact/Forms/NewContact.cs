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
    public partial class NewContact : BaseContact
    {
        private Boolean insertSucces;
        private dBHelper helper = null;

        public NewContact(Boolean i)
        {
            InitializeComponent();
            base.buttonLeft.Text = "New";
            base.buttonRight.Text = "Insert";
            insertSucces = i;
        }
        public Boolean GetInsertSucces()
        {
            return insertSucces;
        }

        private void buttonLeft_Click_1(object sender, EventArgs e)
        {
            base.textBoxId.Text = string.Empty;
            base.textBoxFName.Text = string.Empty;
            base.textBoxLName.Text = string.Empty;
        }

        private void buttonRight_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            if (textBoxId.Text != string.Empty)
            {
                i = Convert.ToInt32(textBoxId.Text);
            }

            if (i > 0)
            {
                base.errorProviderBaseId.SetError(textBoxId, "Contact_Id already exists");
                return;
            }
            else
            {
                base.errorProviderBaseId.SetError(textBoxId, string.Empty);
            }

            if (base.textBoxFName.Text == string.Empty && base.textBoxLName.Text == string.Empty)
            {
                base.errorProviderBaseId.SetError(textBoxFName, "First Name required !");
                return;
            }
            else
            {
                base.errorProviderBaseId.SetError(textBoxId, string.Empty);
            }


            // Determin the ConnectionString
            string connectionString = dBFunctions.ConnectionStringSQLite;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = "SELECT * FROM Contact WHERE 1=0";

            // Make a new object
            helper = new dBHelper(connectionString);
            {
                // Load Data
                if (helper.Load(commandText, "contact_id") == true)
                {
                    // Add a row and determin the row
                    helper.DataSet.Tables[0].Rows.Add(helper.DataSet.Tables[0].NewRow());
                    DataRow dataRow = helper.DataSet.Tables[0].Rows[0];

                    // Enter the given values
                    dataRow["FirstName"] = textBoxFName.Text;
                    dataRow["LastName"] = textBoxLName.Text;

                    try
                    {
                        // Save -> determin succes
                        if (helper.Save() == true)
                        {
                            textBoxId.Text = dataRow["contact_id"].ToString();
                            insertSucces = true;
                            this.Close();
                        }
                        else
                        {
                            insertSucces = false;
                            MessageBox.Show("Error during Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show the Exception --> Dubbel ContactId/Name ?
                        MessageBox.Show(ex.Message);
                    }

                }//END IF
            }
        }



    }
}
