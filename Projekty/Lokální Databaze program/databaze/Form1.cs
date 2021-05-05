using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace databaze
{
    public partial class Form1 : Form
    {
    	Boolean rozhodnutí;
    	dBHelper helper;
        public Form1(bool p)
        {
            InitializeComponent();
            rozhodnutí = p;
        }
		void PřidatData(object sender, EventArgs e)
		{
			if(rozhodnutí)
			{
			int i = 0;
            if (textBox7.Text != string.Empty)
            {
                i = Convert.ToInt32(textBox7.Text);
            }
            if(textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty) //příkaz zjišťující, jestli data označená jako "NotNULL" nejsou prázdná 
			{
				if(textBox1.Text == string.Empty){ errorProvider1.SetError(textBox1,"Kolonka se jménem nesmí být prázdná"); }
				if(textBox2.Text == string.Empty) { errorProvider1.SetError(textBox2,"Kolonka se příjmením nesmí být prázdná"); }
				if(textBox3.Text == string.Empty) { errorProvider1.SetError(textBox3,"Kolonka s obcí nesmí být prázdná"); }
				return;
			}
            if(textBox1.Text == string.Empty || textBox2.Text == string.Empty) //příkaz zjišťující, jestli data označená jako "NotNULL" nejsou prázdná 
				{
					if(textBox1.Text == string.Empty){ errorProvider1.SetError(textBox1,"Kolonka se jménem nesmí být prázdná"); }
					if(textBox2.Text == string.Empty) { errorProvider1.SetError(textBox2,"Kolonka ID Osoby nesmí být prázdná"); }
					return;
				}
			 string connectionString = "URI=file:Evidence_psu.db";

            // Determin the DataAdapter = CommandText + Connection
                string commandText = "SELECT * FROM Osoby WHERE 1=0";
            // Make a new object
            helper = new dBHelper(connectionString);
            {
                // Load Data
                if (helper.Load(commandText, "osoba_id") == true)
                {
                    // Add a row and determin the row
                    helper.DataSet.Tables[0].Rows.Add(helper.DataSet.Tables[0].NewRow());
                    DataRow dataRow = helper.DataSet.Tables[0].Rows[0];

                    // Enter the given values
                    dataRow["Jmeno"] = textBox1.Text;
                    dataRow["Prijmeni"] = textBox2.Text;
                    dataRow["Obec"] = textBox3.Text;
                    dataRow["Ulice"] = textBox4.Text;
                    if(textBox5.Text == String.Empty) { dataRow["Cislo_popisne"] = null; } else { dataRow["Cislo_popisne"] = Convert.ToInt64(textBox5.Text); }
                    dataRow["PSC"] = textBox6.Text;
                    
                    try
                    {
                        // Save -> determin succes
                        if (helper.Save() == true)
                        {
                            textBox7.Text = dataRow["osoba_id"].ToString();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error during Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show the Exception --> Dubbel ContactId/Name ?
                        MessageBox.Show(ex.Message);
                    }
                    
				}
                this.Close();
                MessageBox.Show("Data Byla uspěšně přidána","Edit",MessageBoxButtons.OK);
            }
			}
			else
			{
			int i = 0;
            if (textBox7.Text != string.Empty)
            {
                i = Convert.ToInt32(textBox7.Text);
            }
			 string connectionString = "URI=file:Evidence_psu.db";

            // Determin the DataAdapter = CommandText + Connection
                string commandText = "SELECT * FROM PSI WHERE 1=0";
            // Make a new object
            helper = new dBHelper(connectionString);
            {
                // Load Data
                if (helper.Load(commandText, "pes_id") == true)
                {
                    // Add a row and determin the row
                    helper.DataSet.Tables[0].Rows.Add(helper.DataSet.Tables[0].NewRow());
                    DataRow dataRow = helper.DataSet.Tables[0].Rows[0];

                    // Enter the given values
                    dataRow["Jmeno"] = textBox1.Text;
                    dataRow["Osoba_ID"] = Convert.ToInt64(textBox2.Text);
                    dataRow["Narozen"] = textBox3.Text;
                    
                    try
                    {
                        // Save -> determin succes
                        if (helper.Save() == true)
                        {
                            textBox7.Text = dataRow["Pes_id"].ToString();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error during Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                    	
                        // Show the Exception --> Dubbel ContactId/Name ?
                        MessageBox.Show(ex.Message);
                    }
                    
				}
                MessageBox.Show("Data Byla uspěšně přidána","Edit",MessageBoxButtons.OK);
                this.Close();
            }
			}
		}
		void Form1Load(object sender, EventArgs e)
		{
			if(rozhodnutí)
			{}
			else
			{
				button1.Location = new Point(90,120);
				label7.Text = "Pes_ID:";
        		label1.Text = "Jmeno:";
        		label2.Text = "Osoba_ID:";
        		label3.Text = "Narozen:";
				label4.Visible = false;
				label5.Visible = false;
				label6.Visible = false;
				textBox4.Visible = false;
				textBox5.Visible = false;
				textBox6.Visible = false;
			}
		}
    }
}
