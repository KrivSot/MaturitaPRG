/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 15.05.2021
 * Time: 9:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Databazeh
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog(); // Inicializace OpenFileDialogu, který otevře průzkumník Windows
			ofd.Filter = "Database files (*.db)|*.db"; // Filtr, který určuje, jaké typy souboru lze vybrat
			if(ofd.ShowDialog() == DialogResult.OK){
				if(IsDatabase("URI=file:"+ofd.FileName))
				{
					MainForm mainform = new MainForm("URI=file:"+ofd.FileName); // Inicializace MainFormu a předání parametru konstruktoru MainForm
					mainform.Show(); // Zobrazení Formuláře
				}
			}
		}
		
		private bool IsDatabase(string connectionString)
		{
		    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		    {
		        try
		        {
		            connection.Open(); // Pokusí se otevřít připojení k databázi
		            return true; // Vrácení hodnoty
		        }
		        catch (SqlException)
		        {
		            return false;
		        }
		    }
		}
	}
}
