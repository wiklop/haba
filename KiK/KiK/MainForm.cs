/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2016-11-30
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KiK
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	bool kolejka =true;// true = kolejka X false = kolejka O
		int liczba_kolejek=0;
		
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
	
		}
		
		void ZasadyGryToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Gracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi." +
			                " Pole pole zajęte przez jednego z graczy nie może zmienić właściciela aż do ukończenia rundy.","Zasady gry");
		}
		
		void AutorzyToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Wiktor Łopatka" +"\nMateusz Kuliś","Autorzy");
		}
		
		void WyjścieToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void przycisk_klik(object sender, EventArgs e)
		{
		 	Button b =(Button)sender;
		 	
			if (kolejka){
		 		
		 		b.Text="X";

			}
			else
			{
				b.Text="O";
				
			}
			kolejka=!kolejka;
			b.Enabled=false;
			liczba_kolejek++;
			SprawdzWygrana();
			
		}
		
		private void SprawdzWygrana(){
			bool wygrana=false;
			
			//Rzędy
			if((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled)) wygrana=true;
			
			if((B1.Text==B2.Text)&&(B2.Text==B3.Text)&&(!B1.Enabled)) wygrana=true;
			
			if((C1.Text==C2.Text)&&(C2.Text==C3.Text)&&(!C1.Enabled)) wygrana=true;
			
			//Kolumny
			if((A1.Text==B1.Text)&&(B1.Text==C1.Text)&&(!A1.Enabled)) wygrana=true;
			
			if((A2.Text==B2.Text)&&(B2.Text==C2.Text)&&(!A2.Enabled)) wygrana=true;
			
			if((A3.Text==B3.Text)&&(B3.Text==C3.Text)&&(!A3.Enabled)) wygrana=true;
			
			//Na ukos
			if((A1.Text==B2.Text)&&(B2.Text==C3.Text)&&(!A1.Enabled)) wygrana=true;
			
			if((A3.Text==B2.Text)&&(B2.Text==C1.Text)&&(!A3.Enabled)) wygrana=true;
			
		
		
		
			if(wygrana) {
				WylaczPrzyciski();
				string zwyciezca="";
				if (!kolejka)
					zwyciezca="X";
					else
					zwyciezca="O";

				MessageBox.Show(zwyciezca+" wygrywa!","Koniec gry.");
						}
			else
				if(liczba_kolejek==9) MessageBox.Show("Remis.","Koniec gry.");
		}
		
		
		
		
		
		private void WylaczPrzyciski(){
			try{
			foreach(Control c in Controls){
				Button b =(Button)c;
				b.Enabled=false;
			}
			}
			catch{}
		}
		void NowaGraToolStripMenuItemClick(object sender, EventArgs e)
		{	kolejka=true;
			liczba_kolejek=0;
			try{
			foreach(Control c in Controls){
				Button b =(Button)c;
				b.Enabled=true;
				b.Text="";
			}
			}
			catch{}
	
		}
			void Najazd(object sender, EventArgs e)
		{	Button b =(Button)sender;
		 	
			if (b.Enabled){
				if (kolejka){
		 		
		 		b.Text="X";
		 	

			}
			else
			{	
				b.Text="O";
				
				
			}
			}
	
		}
		void Zjazd(object sender, EventArgs e)
		{	Button b =(Button)sender;
		 	
			if (b.Enabled) b.Text="";
				
				
			
		}

	}
}
