/*
 * Created by SharpDevelop.
 * User: praxe
 * Date: 14.05.2019
 * Time: 10:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace databaze
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		Boolean rozhodnutí;
		int contactId;
		dBHelper helper;
		DataRow dataRow;
		public Form3(bool p,int i)
		{
			InitializeComponent();
			rozhodnutí = p;
			contactId = i;
		}
		
		private void GetData()
        {
        	if(rozhodnutí)
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
	            }
        	}
        	else
        	{
        		button1.Location = new Point(150,185);
        		button2.Location = new Point(21,185);
        		textBox4.Enabled = false;
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
	            }
        	}
        }
		void Form3Load(object sender, EventArgs e)
		{
			GetData();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(rozhodnutí)
			{
				string connectionString = "URI=file:Evidence_psu.db";
	
	            // Determin the DataAdapter = CommandText + Connection
	            string commandText = "SELECT * FROM Osoby WHERE osoba_id=" + contactId;
	
	            // Make a new object
	            helper = new dBHelper(connectionString);
	            {
	                // Load Data
	                if (helper.Load(commandText, "osoba_id") == true)
	                {
	                	DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat data ?", "Upozornění", MessageBoxButtons.YesNo);
							if(dialogResult == DialogResult.Yes)
							{
								using (SQLiteConnection con = new SQLiteConnection("URI=file:Evidence_psu.db"))
		            			{
		                        	con.Open();
			                        string dotaz;
			                        dotaz ="DELETE FROM Osoby WHERE Osoba_id='" + contactId + "'";
			                        SQLiteDataAdapter sda = new SQLiteDataAdapter(dotaz, con);
			                		DataTable dtbl = new DataTable();
			                		DataSet ds = new DataSet();
			                		sda.Fill(dtbl);
			                		con.Close();
		                        }
							}
							else if (dialogResult == DialogResult.No)
							{
								return;
							}    
	                }
	            }
			}
			else
			{
				string connectionString = "URI=file:Evidence_psu.db";
	
	            // Determin the DataAdapter = CommandText + Connection
	            string commandText = "SELECT * FROM PSI WHERE pes_id=" + contactId;
	
	            // Make a new object
	            helper = new dBHelper(connectionString);
	            {
	                // Load Data
	                if (helper.Load(commandText, "pes_id") == true)
	                {
	                        //helper.DataSet.Tables[0].Rows[0].Delete();
	                        DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat data ?", "Upozornění", MessageBoxButtons.YesNo);
							if(dialogResult == DialogResult.Yes)
							{
								using (SQLiteConnection con = new SQLiteConnection("URI=file:Evidence_psu.db"))
		            			{
		                        	con.Open();
			                        string dotaz;
			                        dotaz ="DELETE FROM Psi WHERE pes_id='" + contactId + "'";
			                        SQLiteDataAdapter sda = new SQLiteDataAdapter(dotaz, con);
			                		DataTable dtbl = new DataTable();
			                		DataSet ds = new DataSet();
			                		sda.Fill(dtbl);
			                		con.Close();
		                        
		                        }
							}
							else if (dialogResult == DialogResult.No)
							{
								return;
							}	                        
	                }
	            }
			}
            this.Close();
            MessageBox.Show("Data Byla uspěšně smazána","MessageBox",MessageBoxButtons.OK);
		}
	}
}
