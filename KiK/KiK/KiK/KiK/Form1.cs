
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KiK
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();
			

		}
		//Ustawienie nazw graczy
		void GrajClick(object sender, EventArgs e)//-WŁ
		{
			MainForm.UstawNazwy(gracz1.Text,gracz2.Text);
			this.Close();
	
		}
		//Wykonanie czynności kliknięcia przycisku Graj jeżeli został wciśnięty klawisz ENTER po wprowadzeniu nazwy gracza2
		void Gracz2KeyPress(object sender, KeyPressEventArgs e)//-WŁ
		{
			if (e.KeyChar.ToString() =="\r")
				Graj.PerformClick();
	
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)//-WŁ
		{
			if (checkBox1.Checked) {gracz2.Text="Komputer"; gracz2.Enabled=false;}
			else
			{gracz2.Text=""; gracz2.Enabled=true;}
		}
		
		//Wykonanie czynności kliknięcia przycisku Graj jeżeli został wciśnięty klawisz ENTER jezeli zaznaczono pole gry z komputerem
		void Gracz1(object sender, KeyPressEventArgs e)//-WŁ
		{if (checkBox1.Checked){
				if (e.KeyChar.ToString()=="\r") Graj.PerformClick();
			
			
			}
	
		}
		//Wczytanie obrazka w polu obrazka
		void Form1Load(object sender, EventArgs e)//-MK
		{
		logoKiK.Image= new Bitmap(@"Logo.png");
		}


	
	}
}
