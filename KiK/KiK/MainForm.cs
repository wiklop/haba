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
		static String gracz1, gracz2;
		bool zKomputerem=false;
		
		
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		public static void UstawNazwy(String g1, String g2){
		
			gracz1=g1;	
			gracz2=g2;
		
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
				kolej.Text="Kolejka gracza "+gracz2;
			}
			else
			{
				b.Text="O";
				kolej.Text="Kolejka gracza "+gracz1;
			}
			kolejka=!kolejka;
			b.Enabled=false;
			liczba_kolejek++;
			SprawdzWygrana();
			
			if((!kolejka)&&(zKomputerem)){
				ruchKomputera();
			}
			
		}
		
		
		private void ruchKomputera(){
		//Priorytety komputera
		//1. Wygrywa jeśli może
		//2. Jesli gracz X może wygrac zablokować ruch
		//3.Zajmij pole w rogu
		//4.Zajmij wolne pole
		
		      Button ruch = null;
 
            
            ruch = WygrajLubBlokuj("O"); 
            if (ruch == null)
            {
                ruch = WygrajLubBlokuj("X"); 
                if (ruch == null)
                {
                    ruch = ZajmijRogi();
                    if (ruch == null)
                    {
                        ruch = wolnePole();
                    }
                }
            }
            if(liczba_kolejek<9) ruch.PerformClick();
		
		
		
		
		}
		
		private Button wolnePole(){
			
			Button b =null;
			foreach (Control c in Controls){
				b= c as Button;
				if (b!=null){
					if (b.Text=="") return b;
						
				}
			}
			return null;
		}
		private Button ZajmijRogi(){
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
 
            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
 
            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }
 
            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }
           
            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;
 
            return null;
        }
		
		private Button WygrajLubBlokuj(string znak){
			
			//Wyszukiwanie w poziomie
			if ((A1.Text == znak) && (A2.Text == znak) && (A3.Text == ""))
                return A3;
            if ((A2.Text == znak) && (A3.Text == znak) && (A1.Text == ""))
                return A1;
            if ((A1.Text == znak) && (A3.Text == znak) && (A2.Text == ""))
                return A2;
 
            if ((B1.Text == znak) && (B2.Text == znak) && (B3.Text == ""))
                return B3;
            if ((B2.Text == znak) && (B3.Text == znak) && (B1.Text == ""))
                return B1;
            if ((B1.Text == znak) && (B3.Text == znak) && (B2.Text == ""))
                return B2;
 
            if ((C1.Text == znak) && (C2.Text == znak) && (C3.Text == ""))
                return C3;
            if ((C2.Text == znak) && (C3.Text == znak) && (C1.Text == ""))
                return C1;
            if ((C1.Text == znak) && (C3.Text == znak) && (C2.Text == ""))
                return C2;
            
            //Wyszukiwanie w pionie
 			if ((A1.Text == znak) && (B1.Text == znak) && (C1.Text == ""))
                return C1;
            if ((B1.Text == znak) && (C1.Text == znak) && (A1.Text == ""))
                return A1;
            if ((A1.Text == znak) && (C1.Text == znak) && (B1.Text == ""))
                return B1;
 
            if ((A2.Text == znak) && (B2.Text == znak) && (C2.Text == ""))
                return C2;
            if ((B2.Text == znak) && (C2.Text == znak) && (A2.Text == ""))
                return A2;
            if ((A2.Text == znak) && (C2.Text == znak) && (B2.Text == ""))
                return B2;
 
            if ((A3.Text == znak) && (B3.Text == znak) && (C3.Text == ""))
                return C3;
            if ((B3.Text == znak) && (C3.Text == znak) && (A3.Text == ""))
                return A3;
            if ((A3.Text == znak) && (C3.Text == znak) && (B3.Text == ""))
                return B3;
            
            //Wyszukiwanie na ukos
             if ((A1.Text == znak) && (B2.Text == znak) && (C3.Text == ""))
                return C3;
            if ((B2.Text == znak) && (C3.Text == znak) && (A1.Text == ""))
                return A1;
            if ((A1.Text == znak) && (C3.Text == znak) && (B2.Text == ""))
                return B2;
 
            if ((A3.Text == znak) && (B2.Text == znak) && (C1.Text == ""))
                return C1;
            if ((B2.Text == znak) && (C1.Text == znak) && (A3.Text == ""))
                return A3;
            if ((A3.Text == znak) && (C1.Text == znak) && (B2.Text == ""))
                return B2;
            
            return null;
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
				{
				zwyciezca=gracz1;
				WygraneX.Text=(Int32.Parse(WygraneX.Text)+1).ToString();
				}
					else
					{
				zwyciezca=gracz2;
				WygraneO.Text=(Int32.Parse(WygraneO.Text)+1).ToString();
					}
				MessageBox.Show(zwyciezca+" wygrywa!","Gratulacje!");
				kolej.Text="Gratulacje!";
						}
			else
			{
				if(liczba_kolejek==9)
				{ MessageBox.Show("Remis.","Koniec gry.");
					Remis.Text=(Int32.Parse(Remis.Text)+1).ToString();
					kolej.Text="Koniec gry.";
				}
			}
		}
		
		
		
		
		
		private void WylaczPrzyciski(){
			
			foreach(Control c in Controls){
				try{
				Button b =(Button)c;
				b.Enabled=false;
			}
				catch{}
			}
			
		}
		void NowaGraToolStripMenuItemClick(object sender, EventArgs e)//Zaczyna nowa gre z resetowaniem liczników
		{	kolejka=true;
			liczba_kolejek=0;
			
			WygraneX.Text="0";
			WygraneO.Text="0";
			Remis.Text="0";
			
			foreach(Control c in Controls){
				try{
				Button b =(Button)c;
				b.Enabled=true;
				b.Text="";
			}
				catch{}
			}
			
				
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
		void NowaRundaToolStripMenuItemClick(object sender, EventArgs e)//Zaczyna nową runde bez resetowania liczników
		{

			kolejka=true;
			liczba_kolejek=0;
			
			foreach(Control c in Controls){
				try{
				Button b =(Button)c;
				b.Enabled=true;
				b.Text="";
			}
				catch{}
		}
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Form okno1 = new Form1();
			okno1.ShowDialog();
			if(string.IsNullOrWhiteSpace(gracz1)) gracz1="Pierwszy";
			if(string.IsNullOrWhiteSpace(gracz2)) gracz2="Drugi";
			
			kolej.Text="Kolejka gracza "+gracz1;
			label1.Text=gracz1;
			
			
			if (gracz2=="Komputer"){zKomputerem=true;}
			label3.Text=gracz2;
			
			
			
		}
		void UruchomPonownieToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
		void ObjaśnieniaToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Nowa gra - zaczyna grę odnowa zerując licznik wygranych/porażek zachowując nazwy graczy." +
			                "\n Nowa runda - zaczyna grę odnowa zachowując nazwy graczy i licznik wygranych/porażek."+
			               "\nUruchom ponownie - uruchamia ponownie grę dajac możliwośc zmiany nazw graczy lub gry z komputerem."+
			              "\nWyjście - zamyka grę.","Objaśnienia Menu.");
		}

	}

	}

