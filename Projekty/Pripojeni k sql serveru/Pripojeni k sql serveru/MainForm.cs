/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 23.02.2021
 * Time: 18:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pripojeni_k_sql_serveru
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private ContextMenu contextMenuForColumn1 = new ContextMenu();
		const string connetionString = @"Data Source=vofy.tech;Initial Catalog=krystofjania;User ID=krystofjania;Password=YAd3xYBe7UKoyh8i";
		String sql = "";
		SqlConnection cnn;
		int indexSelected;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void DataGridView1MouseClick(object sender, MouseEventArgs e)
		{
		    if (e.Button == MouseButtons.Right)
		    {
		        ContextMenu m = new ContextMenu();
		        m.MenuItems.Add("Smazat", new EventHandler(RemoveItem));
		        m.MenuItems.Add("Edit", new EventHandler(EditItem));
		        //m.MenuItems.Add("Přidat", new EventHandler(AddItem));

		        indexSelected = dataGridView1.HitTest(e.X,e.Y).RowIndex + 1;
		        m.Show(dataGridView1, new Point(e.X, e.Y));
		    }
		}
		
		#region Smazání, Editace a Přidání dat do Majitelů
		void RemoveItem(object sender, EventArgs e){
			
			cnn = new SqlConnection(connetionString);
   			cnn.Open();
   			Int32 i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); // Získání ID hodnoty
   			sql = "Delete from Majitele where MajitelID ='"+i+"'";
   			DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat data ?", "Upozornění", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				SQLDotaz(sql);			
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}    
		}
		
		void EditItem(object sender, EventArgs e){
			sql = "UPDATE Majitele SET Jmeno = '"+dataGridView1.CurrentRow.Cells[1].Value+"', Prijmeni= '"+dataGridView1.CurrentRow.Cells[2].Value+"' WHERE MajitelID = "+dataGridView1.CurrentRow.Cells[0].Value+"";
			SQLDotaz(sql);
		}
		
		void AddItem(object sender, EventArgs e){
			Form1 frm = new Form1();
            frm.ShowDialog();
            frm.Dispose();
		}
		#endregion
		
		#region Zpracování dotazů pro tabulky
		void SQLDotaz(String Dotaz) //Metoda, která zpracuje dotaz
		{
			DataTable dtbl = new DataTable();
   			SqlDataAdapter sda = new SqlDataAdapter(Dotaz,cnn);
   			sda.Fill(dtbl);
   			dataGridView1.DataSource = dtbl;
   			
   			ShowData();

		}
		
		void SQLDotazPsi(String Dotaz)
		{
			DataTable dtbl = new DataTable();
   			SqlDataAdapter sda = new SqlDataAdapter(Dotaz,cnn);
   			sda.Fill(dtbl);
   			dataGridView2.DataSource = dtbl;
		}
		
		void ShowData()
		{
			
			DataTable dtbl = new DataTable();
   			SqlDataAdapter sda = new SqlDataAdapter("Select * from Majitele",cnn);
   			sda.Fill(dtbl);
   			dataGridView1.DataSource = dtbl;
		}
		#endregion
		
		void InfoClick(object sender, EventArgs e) // Zobrazí info
		{
			MessageBox.Show("Pro editaci hodnot změňte hodnoty v tabulce a potom otevřete ContextMenu(Pravé tlačítko) a klikněte na možnost Edit.");
		}
		void MainFormActivated(object sender, EventArgs e)
		{
			cnn = new SqlConnection(connetionString);
			SQLDotaz("Select * from Majitele");
			SQLDotazPsi("Select * from Psi");
			dataGridView1.Columns["MajitelID"].ReadOnly = true;
		}
		void DataGridView1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			sql = "Select * From Psi where MajitelID = '"+dataGridView1.CurrentRow.Cells[0].Value+"'";
			SQLDotazPsi(sql);
		}
			
		// IGNOROVAT - SQL dotazy
		/*CREATE TABLE Majitele (
    MajitelID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Jmeno varchar(255) NOT NULL,
    Prijmeni varchar(255) NOT NULL,
);

INSERT INTO Majitele (Jmeno,Prijmeni)
VALUES ('Tomáš','Batelka');*/
			
	}
}
