
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
		void GrajClick(object sender, EventArgs e)
		{
			MainForm.UstawNazwy(gracz1.Text,gracz2.Text);
			this.Close();
	
		}
		void Gracz2KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString() =="\r")
				Graj.PerformClick();
	
		}

		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	if (checkBox1.Checked) {gracz2.Text="Komputer"; gracz2.Enabled=false;}
			else
			{gracz2.Text=""; gracz2.Enabled=true;}
		}
		
		
		void Gracz1(object sender, KeyPressEventArgs e)
		{if (checkBox1.Checked){
				if (e.KeyChar.ToString()=="\r") Graj.PerformClick();
			
			
			}
	
		}
		void Form1Load(object sender, EventArgs e)
		{
		logoKiK.Image= new Bitmap(@"Logo.png");
		}


	
	}
}
