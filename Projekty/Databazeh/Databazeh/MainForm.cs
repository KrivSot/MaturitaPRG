/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 15.05.2021
 * Time: 9:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace Databazeh
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		private ContextMenu contextMenuForColumn1 = new ContextMenu(); // Kontext menu pro tabulky
		SQLiteConnection con; // Inicializace SQLiteConnection se kterou budeme manipulovat s databází
		bool prvni = true;
		DataGridView PomocnyDGV;
		
		public MainForm(String conString)
		{
			InitializeComponent();
			con = new SQLiteConnection(conString); // Inicializace SQLiteConnection
			PomocnyDGV = dataGridView1;
			FillCombobox(); // Naplnění Comboboxů
			FillTables(); // Naplnění tabulek
		}
		
		public void FillTables()
		{
			con.Open(); //Otevření připojení pro databázi
			
			//Předání tabulky s daty
			dataGridView1.DataSource = SQLDotaz("Select * from "+comboBox1.SelectedItem);
			dataGridView2.DataSource = SQLDotaz("Select * from "+comboBox2.SelectedItem);
			
			// Nastavení ID tabulky na ReadOnly, aby se při editaci nemohla měnit
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView2.Columns[0].ReadOnly = true;
			
			con.Close(); //Zavření připojení pro databázi
		}
		
		//Procedura, která 
		public void FillCombobox()
		{
			con.Open();
			DataTable t = SQLDotaz("Select name From sqlite_master where type='table' order by name;"); //Zavolání funkce SQLDotaz, která vrátí DataTable s vybranými daty
			DataRow[] dr = t.Select();
			foreach(DataRow row in dr) //Cyklus, který projede pole
			{
				if(!row.Field<string>("name").Equals("sqlite_sequence"))
				{
					comboBox1.Items.Add(row.Field<string>("name"));
					comboBox2.Items.Add(row.Field<string>("name"));
				}
			}
			//Nastaví vybranou hodnotu pro comboboxy
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
			prvni = false;
			con.Close(); //Zavře připojení k databázi
		}
		
		public DataTable SQLDotaz(String Dotaz)
		{
			  DataTable dtbl = new DataTable();//Inicializace DataTable
			  SQLiteDataAdapter sda = new SQLiteDataAdapter(Dotaz,con); // Předání dotazu
			  sda.Fill(dtbl); //Zavolání metody Fill, která provede dotaz a naplní Datatable
			  return dtbl; //Vrací upravenou tabulku s vybranými daty
		}
		
		//Aktualizuje tabulky při změně vybrané hodnoty v comboboxu
		void SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!prvni)
			{
				FillTables();
			}
		}
		
		int indexSelected; // Zjistí vybraný index
		
		void DataGridViewMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
		    {
		        ContextMenu m = new ContextMenu();
		        m.MenuItems.Add("Smazat", new EventHandler(RemoveItem));
		        m.MenuItems.Add("Edit", new EventHandler(EditItem));
		        //m.MenuItems.Add("Přidat", new EventHandler(AddItem));

		        PomocnyDGV = (DataGridView)sender;
		        indexSelected = PomocnyDGV.HitTest(e.X,e.Y).RowIndex + 1;
		        m.Show(PomocnyDGV, new Point(e.X, e.Y));
		    }
		}
		
		#region Smazání, Editace a Přidání dat do Majitelů
		void RemoveItem(object sender, EventArgs e){
   			con.Open();
   			Int32 i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); // Získání ID hodnoty
   			DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat data ?", "Upozornění", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				foreach(String tabulka in comboBox1.Items)
				{
					SQLDotaz("Delete from "+tabulka+" where "+PomocnyDGV.Columns[0].Name+" ='"+i+"'");
				}
				con.Close();
				FillTables();
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
				
			}
			con.Close();
		}
		
		void EditItem(object sender, EventArgs e){
			string EditDotaz = "";
			for(int i = 0; i< dataGridView1.Columns.Count;i++)
			{
				if(i == 0) { EditDotaz =  "UPDATE "+comboBox1.SelectedItem+ " SET "; }
				else if(i ==1) { EditDotaz = EditDotaz +PomocnyDGV.Columns[i].Name+" = '"+PomocnyDGV.CurrentRow.Cells[i].Value+"'"; }
				else { EditDotaz = EditDotaz + ", "+PomocnyDGV.Columns[i].Name+" = '"+PomocnyDGV.CurrentRow.Cells[i].Value+"'";  }
			}
			EditDotaz = EditDotaz + "WHERE "+PomocnyDGV.Columns[0].Name+" = "+PomocnyDGV.CurrentRow.Cells[0].Value+"";
			SQLDotaz(EditDotaz);
			FillTables();
		}
		void Vyhledavac(object sender, EventArgs e)
		{
			PomocnyDGV.DataSource = SQLDotaz("SELECT * FROM "+comboBox1.SelectedItem+" WHERE "+PomocnyDGV.Columns[1].Name+" LIKE '%"+textBox1.Text+"%'");
		}
		
		/*void AddItem(object sender, EventArgs e){
			Form1 frm = new Form1();
            frm.ShowDialog();
            frm.Dispose();
		}*/
		#endregion
	}
}
