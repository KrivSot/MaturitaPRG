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
    public partial class Form2 : Form
    {
        private Boolean editSucces = false;
        private Boolean Edit = false;
        private Int32 contactId;
        private dBHelper helper = null;
        private DataRow dataRow = null;
        private String oldFName = string.Empty;
        private String oldLName = string.Empty;
        private String oldMesto = string.Empty;
        private String oldUlice = string.Empty;
        private String oldCP = string.Empty;
        private String oldPSC = string.Empty;
        public Form2(int i, bool NewContactEdit,bool coEdit)
        {
            InitializeComponent();
            contactId = i;
            editSucces = NewContactEdit;
            Edit = coEdit;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetData();
        }
        
        private void GetData()
        {
        	if(Edit)
        	{
	            string connectionString = "URI=file:Evidence_psu.db";
	
	            // Determin the DataAdapter = CommandText + Connection
	            string commandText = @"SELECT * FROM Osoby WHERE Osoba_id =" + contactId;
	            // Make a new object
	            helper = new dBHelper(connectionString);
	            // Load the data
	            if (helper.Load(commandText, "") == true)
	            {
	                // Show the data in the datagridview
	                dataRow = helper.DataSet.Tables[0].Rows[0];
	                textBox1.Text = dataRow[0].ToString();
	                textBox2.Text = dataRow[1].ToString();
	                textBox3.Text = dataRow[2].ToString();
	                textBox4.Text = dataRow[3].ToString();
	                textBox5.Text = dataRow[4].ToString();
	                textBox6.Text = dataRow[5].ToString();
	                textBox7.Text = dataRow[6].ToString();
	                oldFName = dataRow[1].ToString();
	                oldLName = dataRow[2].ToString();
	                oldMesto = dataRow[3].ToString();
	                oldUlice = dataRow[4].ToString();
	                oldCP = dataRow[5].ToString();
	                oldPSC = dataRow[6].ToString();
	            }
        	}
        	else
        	{
        		button1.Location = new Point(38,185);
        		button2.Location = new Point(207,185);
        		textBox4.Enabled = true;
        		textBox5.Visible = false;
        		textBox6.Visible = false;
        		textBox7.Visible = false;
        		label1.Text = "Pes_ID:";
        		label2.Text = "Jmeno:";
        		label3.Text = "Osoba_ID:";
        		label4.Text = "Narozen:";
        		label5.Visible = false;
        		label6.Visible = false;
        		label7.Visible = false;
        		
        		string connectionString = "URI=file:Evidence_psu.db";
	
	            // Determin the DataAdapter = CommandText + Connection
	            string commandText = @"SELECT * FROM PSI WHERE Pes_id =" + contactId;
	            // Make a new object
	            helper = new dBHelper(connectionString);
	            // Load the data
	            if (helper.Load(commandText, "") == true)
	            {
	                // Show the data in the datagridview
	                dataRow = helper.DataSet.Tables[0].Rows[0];
	                textBox1.Text = dataRow[0].ToString();
	                textBox2.Text = dataRow[1].ToString();
	                textBox3.Text = dataRow[2].ToString();
	                textBox4.Text = dataRow[3].ToString();
	                oldFName = dataRow[1].ToString();
	                oldLName = dataRow[2].ToString();
	                oldMesto = dataRow[3].ToString();
	            }
        	}
        }
		void ResetData(object sender, EventArgs e) //Nastavení dat do původních hodnot
		{
			if(Edit)
			{
			dataRow[1] = oldFName;
            dataRow[2] = oldLName;
            dataRow[3] = oldMesto;
            dataRow[4] = oldUlice;
            dataRow[5] = oldCP;
            dataRow[6] = oldPSC;
			}
			else
			{
				dataRow[1] = oldFName;
            	dataRow[2] = oldLName;
            	dataRow[3] = oldMesto;
			}
            GetData();
		}
		void EditData(object sender, EventArgs e)
		{
			errorProvider1.Dispose();
			if(Edit)
			{
			if(textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty) //příkaz zjišťující, jestli data označená jako "NotNULL" nejsou prázdná 
			{
				if(textBox2.Text == string.Empty){ errorProvider1.SetError(textBox2,"Kolonka se jménem nesmí být prázdná"); }
				if(textBox3.Text == string.Empty) { errorProvider1.SetError(textBox3,"Kolonka se příjmením nesmí být prázdná"); }
				if(textBox4.Text == string.Empty) { errorProvider1.SetError(textBox4,"Kolonka s obcí nesmí být prázdná"); }
				return;
			}
			string connectionString = "URI=file:Evidence_psu.db";
            string commandText = @"SELECT * FROM Osoby WHERE Osoba_id =" + contactId;
            helper = new dBHelper(connectionString);
            {
             if (helper.Load(commandText, "Osoba_id") == true)
                {
                    // Determin if the row was found
                    if (helper.DataSet.Tables[0].Rows.Count == 1)
                    {
                        // Determin the found row
                        DataRow dataRow = helper.DataSet.Tables[0].Rows[0];

                        // Modify the row
                        dataRow["Jmeno"] = textBox2.Text;
                        dataRow["Prijmeni"] = textBox3.Text;
                        using (SQLiteConnection con = new SQLiteConnection("URI=file:Evidence_psu.db"))
            			{
                        con.Open();
                        string dotaz;
                        dotaz ="UPDATE Osoby SET Jmeno ='" + textBox2.Text + "' WHERE Osoba_id='" + contactId + "'";
                        SQLiteDataAdapter sda = new SQLiteDataAdapter(dotaz, con);
                		DataTable dtbl = new DataTable();
                		DataSet ds = new DataSet();
                		sda.Fill(dtbl);
                		dotaz ="UPDATE Osoby SET Prijmeni ='" + textBox3.Text + "' WHERE Osoba_id='" + contactId + "'";
                        sda = new SQLiteDataAdapter(dotaz, con);
                		dtbl = new DataTable();
                		ds = new DataSet();
                		sda.Fill(dtbl);
                		dotaz ="UPDATE Osoby SET Obec ='" + textBox4.Text + "' WHERE Osoba_id='" + contactId + "'";
                        sda = new SQLiteDataAdapter(dotaz, con);
                		dtbl = new DataTable();
                		ds = new DataSet();
                		sda.Fill(dtbl);
                		dotaz ="UPDATE Osoby SET Ulice ='" + textBox5.Text + "' WHERE Osoba_id='" + contactId + "'";
                        sda = new SQLiteDataAdapter(dotaz, con);
                		dtbl = new DataTable();
                		ds = new DataSet();
                		sda.Fill(dtbl);
                		dotaz ="UPDATE Osoby SET cislo_popisne ='" + Convert.ToInt32(textBox6.Text) + "' WHERE Osoba_id='" + contactId + "'";
                        sda = new SQLiteDataAdapter(dotaz, con);
                		dtbl = new DataTable();
                		ds = new DataSet();
                		sda.Fill(dtbl);
                		dotaz ="UPDATE Osoby SET PSC ='" + textBox7.Text + "' WHERE Osoba_id='" + contactId + "'";
                        sda = new SQLiteDataAdapter(dotaz, con);
                		dtbl = new DataTable();
                		ds = new DataSet();
                		sda.Fill(dtbl);
                        }
                        editSucces = true;
                        this.Close();
                        MessageBox.Show("Úprava Dat Byla uspěšná","Edit",MessageBoxButtons.OK);
                    }
             }
            }
			}
			else
			{
				if(textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty) //příkaz zjišťující, jestli data označená jako "NotNULL" nejsou prázdná 
				{
					if(textBox2.Text == string.Empty){ errorProvider1.SetError(textBox2,"Kolonka se jménem nesmí být prázdná"); }
					if(textBox3.Text == string.Empty) { errorProvider1.SetError(textBox3,"Kolonka s id Osoby nesmí být prázdná"); }
					return;
				}
				
				string connectionString = "URI=file:Evidence_psu.db";
	            string commandText = @"SELECT * FROM Psi WHERE Pes_ID =" + contactId;
	            helper = new dBHelper(connectionString);

	             if (helper.Load(commandText, "Pes_id") == true)
	                {
	                    // Determin if the row was found
	                    if (helper.DataSet.Tables[0].Rows.Count == 1)
	                    {
	                        // Determin the found row
	                        DataRow dataRow = helper.DataSet.Tables[0].Rows[0];
	
	                        // Modify the row
	                        dataRow["Jmeno"] = textBox2.Text;
	                        dataRow["Osoba_ID"] = textBox3.Text;
	                        using (SQLiteConnection con = new SQLiteConnection("URI=file:Evidence_psu.db"))
	            			{
	                        con.Open();
	                        string dotaz;
	                        dotaz ="UPDATE PSI SET Jmeno ='" + textBox2.Text + "' WHERE Pes_ID='" + contactId + "'";
	                        SQLiteDataAdapter sda = new SQLiteDataAdapter(dotaz, con);
	                		DataTable dtbl = new DataTable();
	                		DataSet ds = new DataSet();
	                		sda.Fill(dtbl);
	                		dotaz ="UPDATE Psi SET Osoba_ID ='" + Convert.ToInt32(textBox3.Text) + "' WHERE Pes_ID='" + contactId + "'";
	                        sda = new SQLiteDataAdapter(dotaz, con);
	                		dtbl = new DataTable();
	                		ds = new DataSet();
	                		sda.Fill(dtbl);
	                		dotaz ="UPDATE Psi SET Narozen ='" + textBox3.Text + "' WHERE Pes_ID='" + contactId + "'";
	                        sda = new SQLiteDataAdapter(dotaz, con);
	                		dtbl = new DataTable();
	                		ds = new DataSet();
	                		sda.Fill(dtbl);
	                        }
	                        editSucces = true;
	                        this.Close();
	                        MessageBox.Show("Úprava Dat Byla uspěšná","Edit",MessageBoxButtons.OK);
	                    }
	             }
			}
		}
		public Boolean GetEditSucces()
		{
			return editSucces;
		}
    }
}
