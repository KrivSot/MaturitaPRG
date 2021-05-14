/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 26.02.2021
 * Time: 20:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Delegat
{
	public delegate void Del1();
	class Program
	{
		public static void Main(string[] args)
		{
			Trezor kovomat1236 = new Trezor(8,4,2);
			kovomat1236.Utok += new Del1(Poplach);
			kovomat1236.Utok += new Del1(VolejPolicii);
			string hsl = null;
			do
			{
				Console.Write("Zadej heslo pro otevření trezoru");
				hsl = Console.ReadLine();
				kovomat1236.Odemkni(hsl);
			}
			while (!kovomat1236.Odemceno);
			
			if(kovomat1236.Odemceno)
			{
				Console.WriteLine("Trezor je odemčen");
			}
			else{ Console.WriteLine("Trezor je zamčen");}
			Console.WriteLine("Objem trezoru je:"+kovomat1236.Objem());
			Console.ReadKey();
		}
		
		static void VolejPolicii()
		{
			Console.WriteLine("Volam Policii");
		}
		
		static void Poplach()
		{
			Console.WriteLine("Poplach");
		}
	}
	
	class Skrin
	{
		int Vyska;
		int Sirka;
		int Hloubka;
		
		public Skrin(int v, int s, int h)
		{
			Vyska = v;
			Sirka = s;
			Hloubka = h;
		}
		
		public int Objem()
		{
			return this.Vyska * this.Sirka * this.Hloubka;
		}
	}
	
	class Trezor:Skrin
	{
		public event Del1 Utok;
		private string heslo;
		private bool odemceno;
		
		public Trezor(int v, int s, int h): base(v,s,h)
		{
			this.odemceno = false;
			this.heslo = "letadlo";
		}
		
		public bool Odemceno{
			get { return odemceno; }
		}
		
		public void Odemkni(string h)
		{
			if(h == heslo)
			{
				odemceno = true;
			}
			else Utok();
		}
	}
}