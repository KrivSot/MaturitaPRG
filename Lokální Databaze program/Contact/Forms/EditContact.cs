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
    public partial class EditContact : BaseContact
    {
        private Boolean editSucces;
        private Int32 contactId;
        private dBHelper helper = null;
        private DataRow dataRow = null;
        private String oldFName = string.Empty;
        private String oldLName = string.Empty;

        public EditContact(Boolean i, Int32 j)
        {
            InitializeComponent();
            base.buttonLeft.Text = "Reset";
            base.buttonRight.Text = "Edit";
            editSucces = i;
            contactId = j;
        }
        public Boolean GetEditSucces()
        {
            return editSucces;
        }

        private void EditContact_Load(object sender, EventArgs e)
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
                oldFName = dataRow[1].ToString();
                oldLName = dataRow[2].ToString();
            }
        }

        private void buttonLeft_Click_1(object sender, EventArgs e)
        {
            if (CompareValues() == false)
            { 
                // return the original values
                dataRow[1] = oldFName;
                dataRow[2] = oldLName;
            }
        }
        private Boolean CompareValues()
        {
            String currFName = dataRow[1].ToString();
            String currLName = dataRow[2].ToString();
            Boolean isSame = false;
            if (currFName == dataRow[1].ToString() && currLName == dataRow[2].ToString())
            {
                isSame = true;
            }
            return isSame;
        }

        private void buttonRight_Click_1(object sender, EventArgs e)
        {
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
                        // Determin the found row
                        DataRow dataRow = helper.DataSet.Tables[0].Rows[0];

                        // Modify the row
                        dataRow["FirstName"] = textBoxFName.Text;
                        dataRow["LastName"] = textBoxLName.Text;
                        
                         string updateText ="UPDATE contact SET FirstName ='" + textBoxFName.Text + "' WHERE contact_id='" + contactId + "'";
                         helper.setSqlCommand(updateText);
                       

                        try
                        {
                            // Save -> determin succes
                            if (helper.Save() == true)
                            {
                                editSucces = true;
                                MessageBox.Show("Modification succesfull");
                                this.Close();
                            }
                            else
                            {
                                editSucces = false;
                                MessageBox.Show("Modification failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show the Exception --> Dubbel ContactId/Name ?
                            MessageBox.Show(ex.Message);
                        }
                    }
                }//END IF
            }

        }
    }
}
