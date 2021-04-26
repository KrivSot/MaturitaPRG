/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 24.02.2021
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pripojeni_k_sql_serveru
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		
		public Form1(){ InitializeComponent(); }
		
		void PřidatData(object sender, EventArgs e)
		{
			if(JmenoTextBox.Text != string.Empty || PrijmeniTextBox.Text != string.Empty)
			{
				SqlConnection conn = new SqlConnection("Data Source=vofy.tech; Database=krystofjania;User Id=krystofjania;Password=YAd3xYBe7UKoyh8i");
				conn.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO Majitele (Jmeno,Prijmeni) VALUES ('"+JmenoTextBox.Text+"','"+PrijmeniTextBox.Text+"');", conn);
				cmd.ExecuteNonQuery();
				Dispose();
			}
		}
	}
}
