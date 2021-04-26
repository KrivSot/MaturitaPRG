/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 06.05.2019
 * Time: 7:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace databaze
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private bool prvninacteni = false;
		public MainForm()
		{
			InitializeComponent();
		}
		
		#region Načtení Formuláře
		void MainFormLoad(object sender, EventArgs e)
		{
			string conString = "URI=file:Evidence_psu.db";
			
            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM OSOBY",con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                con.Close();
                
            }
            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM PSI", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                con.Close();
                
            }
            
            if(prvninacteni == false){ radioButton1.Checked = true; prvninacteni = true;}
		}
		#endregion

		#region Přídat Data
        private void PridatData(object sender, EventArgs e)
        {
            Form1 frm = new Form1(radioButton1.Checked);
            frm.ShowDialog();
            frm.Dispose();
        }
        #endregion

        #region Aktualizace dat - Zatím není potřeba
        private void Update(object sender, EventArgs e)
        {
            string conString = "URI=file:Evidence_psu.db";

            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM OSOBY",con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                con.Close();
            }
            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM PSI", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                con.Close();
            }
        }
        #endregion

        #region Editace
        public Form2 form2;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        	Int32 i;
        	if(radioButton1.Checked) { i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); }
        	else { i = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value); }
            bool edit = false;
            
            if(form2 == null || form2.IsDisposed)
            {
            Form2 frm2 = new Form2(i,edit,radioButton1.Checked);
            frm2.ShowDialog();
            frm2.Dispose();
            edit = frm2.GetEditSucces();
            }
            else
            {
            	form2.Activate();
            }
        }
        #endregion
        
        #region načtení Formuláře
		void MainFormClick(object sender, EventArgs e)
		{
			MainFormLoad(sender, e);
		}
		#endregion
		
		#region ukáže relaci
		void UkažRelaci(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) == "")
			{
			string conString = "URI=file:Evidence_psu.db";
					using (SQLiteConnection con = new SQLiteConnection(conString))
	            	{
	                con.Open();
	                string Dotaz = "Select * FROM Psi ";
	                SQLiteDataAdapter sda = new SQLiteDataAdapter(Dotaz, con);
	                DataTable dtbl = new DataTable();
	                DataSet ds = new DataSet();
	                sda.Fill(dtbl);
	                dataGridView2.DataSource = dtbl;
	                con.Close();
	            	}
			}
			else
			{
				Int32 i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				string conString2 = "URI=file:Evidence_psu.db";
				using (SQLiteConnection con = new SQLiteConnection(conString2))
            	{
                con.Open();
                string Dotaz = "Select * FROM Psi where Osoba_ID = "+i;
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Dotaz, con);
                DataTable dtbl = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                con.Close();
            	}
			}
		}
		#endregion
		
		#region Vyhledávač
		void Vyhledávač(object sender, EventArgs e)
		{
			if(textBox1.Text == "")
			{
				MainFormLoad(sender,e);
			}
			else
			{
				
			string Dotaz;
			string conString2 = "URI=file:Evidence_psu.db";
			if(radioButton1.Checked)
			{
				using (SQLiteConnection con = new SQLiteConnection(conString2))
	            {
	                con.Open();
	                string vyber;
	                vyber = listBox1.GetItemText(listBox1.SelectedItem);
	                switch(vyber)
	                {
	                	case "Jmeno": Dotaz = "Select * FROM Osoby where Jmeno like '%"+textBox1.Text+"%'"; break;
	                	case "Prijmeni": Dotaz = "Select * FROM Osoby where Prijmeni like '%"+textBox1.Text+"%'"; break;
	                	case "Obec": Dotaz = "Select * FROM Osoby where Obec like '%"+textBox1.Text+"%'"; break;
	                	case "Ulice": Dotaz = "Select * FROM Osoby where Ulice like '%"+textBox1.Text+"%'"; break;
	                	case "cislo_popisne": Dotaz = "Select * FROM Osoby where cislo_popisne like '%"+textBox1.Text+"%'"; break;
	                	case "PSC": Dotaz = "Select * From Osoby where PSC like '%"+Convert.ToInt32(textBox1.Text)+"%'"; break;
	                	default: Dotaz = "SELECT * FROM OSOBY";break;
	                }
	                SQLiteDataAdapter sda = new SQLiteDataAdapter(Dotaz, con);
	                DataTable dtbl = new DataTable();
	                DataSet ds = new DataSet();
	                sda.Fill(dtbl);
	                dataGridView1.DataSource = dtbl;
	                con.Close();
	            }
			}
			else
			{
				using (SQLiteConnection con = new SQLiteConnection(conString2))
	            {
	                con.Open();
	                string vyber;
	                vyber = listBox2.GetItemText(listBox2.SelectedItem);
	                switch(vyber)
	                {
	                	case "Jmeno": Dotaz = "Select * FROM Psi where Jmeno like '%"+textBox1.Text+"%'"; break;
	                	case "Osoba_ID": Dotaz = "Select * FROM Psi where Osoba_ID like '%"+textBox1.Text+"%'"; break;
	                	case "Narozen": Dotaz = "Select * FROM Psi where Narozen like '%"+textBox1.Text+"%'"; break;
	                	default: Dotaz = "SELECT * FROM Psi";break;
	                }
	                SQLiteDataAdapter sda = new SQLiteDataAdapter(Dotaz, con);
	                DataTable dtbl = new DataTable();
	                DataSet ds = new DataSet();
	                sda.Fill(dtbl);
	                dataGridView2.DataSource = dtbl;
	                con.Close();
	            }
			
			}
			}
		}
		#endregion
		
		#region Po Kliknutí ukáže jméno
		void UkažJméno(object sender, DataGridViewCellMouseEventArgs e)
		{
			string Jmeno = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
			string Prijmeni = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
			MessageBox.Show(Jmeno + ' ' +Prijmeni );
		}
		
		void UkažJménoP(object sender, DataGridViewCellEventArgs e)
		{
			string Jmeno = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
			string Prijmeni = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
			MessageBox.Show(Jmeno + ", "+' '+"Majitel :" +Prijmeni );
		}
		#endregion
		
		#region aktualizace dat pokaždé když je MainForm aktivní
		void MainFormActivated(object sender, EventArgs e)
		{
			MainFormLoad(sender, e);
		}
		#endregion
		
		#region Vybrání co se bude editovat/vyhledávat
		void VaEPsu(object sender, EventArgs e)
		{
			if( radioButton2.Checked)
			{
				listBox1.Visible = false;
				listBox2.Visible = true;
			}
		}
		
		void VaEOsob(object sender, EventArgs e)
		{
			if( radioButton1.Checked)
			{
				listBox1.Visible = true;
				listBox2.Visible = false;
			}
		}
		#endregion
		
		#region Smaže Data
		void SmazatData(object sender, EventArgs e)
		{
			Int32 i;
        	if(radioButton1.Checked) { i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); }
        	else { i = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value); }
			Form3 frm3 = new Form3(radioButton1.Checked,i);
			frm3.ShowDialog();
			frm3.Dispose();
		}
		#endregion
	}
}
