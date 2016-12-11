/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2016-11-30
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KiK
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zasadyGryToolStripMenuItem;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label WygraneX;
		private System.Windows.Forms.Label Remis;
		private System.Windows.Forms.Label WygraneO;
		private System.Windows.Forms.ToolStripMenuItem NowaRundaToolStripMenuItem;
		private System.Windows.Forms.TextBox kolej;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem uruchomPonownieToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem objaśnieniaToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NowaRundaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uruchomPonownieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objaśnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zasadyGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.WygraneX = new System.Windows.Forms.Label();
			this.Remis = new System.Windows.Forms.Label();
			this.WygraneO = new System.Windows.Forms.Label();
			this.kolej = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.plikToolStripMenuItem,
			this.pomocToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(367, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nowaGraToolStripMenuItem,
			this.NowaRundaToolStripMenuItem,
			this.uruchomPonownieToolStripMenuItem,
			this.wyjścieToolStripMenuItem});
			this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.plikToolStripMenuItem.Text = "Plik";
			// 
			// nowaGraToolStripMenuItem
			// 
			this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
			this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nowaGraToolStripMenuItem.Text = "Nowa Gra";
			this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.NowaGraToolStripMenuItemClick);
			// 
			// NowaRundaToolStripMenuItem
			// 
			this.NowaRundaToolStripMenuItem.Name = "NowaRundaToolStripMenuItem";
			this.NowaRundaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.NowaRundaToolStripMenuItem.Text = "Nowa Runda";
			this.NowaRundaToolStripMenuItem.Click += new System.EventHandler(this.NowaRundaToolStripMenuItemClick);
			// 
			// uruchomPonownieToolStripMenuItem
			// 
			this.uruchomPonownieToolStripMenuItem.Name = "uruchomPonownieToolStripMenuItem";
			this.uruchomPonownieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.uruchomPonownieToolStripMenuItem.Text = "Uruchom ponownie";
			this.uruchomPonownieToolStripMenuItem.Click += new System.EventHandler(this.UruchomPonownieToolStripMenuItemClick);
			// 
			// wyjścieToolStripMenuItem
			// 
			this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
			this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.wyjścieToolStripMenuItem.Text = "Wyjście";
			this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.WyjścieToolStripMenuItemClick);
			// 
			// pomocToolStripMenuItem
			// 
			this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.objaśnieniaToolStripMenuItem,
			this.zasadyGryToolStripMenuItem,
			this.autorzyToolStripMenuItem});
			this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
			this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.pomocToolStripMenuItem.Text = "Pomoc";
			// 
			// objaśnieniaToolStripMenuItem
			// 
			this.objaśnieniaToolStripMenuItem.Name = "objaśnieniaToolStripMenuItem";
			this.objaśnieniaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.objaśnieniaToolStripMenuItem.Text = "Objaśnienia";
			this.objaśnieniaToolStripMenuItem.Click += new System.EventHandler(this.ObjaśnieniaToolStripMenuItemClick);
			// 
			// zasadyGryToolStripMenuItem
			// 
			this.zasadyGryToolStripMenuItem.Name = "zasadyGryToolStripMenuItem";
			this.zasadyGryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.zasadyGryToolStripMenuItem.Text = "Zasady gry";
			this.zasadyGryToolStripMenuItem.Click += new System.EventHandler(this.ZasadyGryToolStripMenuItemClick);
			// 
			// autorzyToolStripMenuItem
			// 
			this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
			this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.autorzyToolStripMenuItem.Text = "Autorzy";
			this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.AutorzyToolStripMenuItemClick);
			// 
			// A1
			// 
			this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A1.Location = new System.Drawing.Point(27, 56);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(100, 100);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.przycisk_klik);
			this.A1.MouseEnter += new System.EventHandler(this.Najazd);
			this.A1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// A2
			// 
			this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A2.Location = new System.Drawing.Point(133, 56);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(100, 100);
			this.A2.TabIndex = 2;
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.przycisk_klik);
			this.A2.MouseEnter += new System.EventHandler(this.Najazd);
			this.A2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// A3
			// 
			this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A3.Location = new System.Drawing.Point(239, 56);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(100, 100);
			this.A3.TabIndex = 3;
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.przycisk_klik);
			this.A3.MouseEnter += new System.EventHandler(this.Najazd);
			this.A3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B1
			// 
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B1.Location = new System.Drawing.Point(27, 162);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(100, 100);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.przycisk_klik);
			this.B1.MouseEnter += new System.EventHandler(this.Najazd);
			this.B1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B2
			// 
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B2.Location = new System.Drawing.Point(133, 162);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(100, 100);
			this.B2.TabIndex = 5;
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.przycisk_klik);
			this.B2.MouseEnter += new System.EventHandler(this.Najazd);
			this.B2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B3
			// 
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B3.Location = new System.Drawing.Point(239, 162);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(100, 100);
			this.B3.TabIndex = 6;
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.przycisk_klik);
			this.B3.MouseEnter += new System.EventHandler(this.Najazd);
			this.B3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C1
			// 
			this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C1.Location = new System.Drawing.Point(27, 268);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(100, 100);
			this.C1.TabIndex = 7;
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.przycisk_klik);
			this.C1.MouseEnter += new System.EventHandler(this.Najazd);
			this.C1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C2
			// 
			this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C2.Location = new System.Drawing.Point(133, 268);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(100, 100);
			this.C2.TabIndex = 8;
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.przycisk_klik);
			this.C2.MouseEnter += new System.EventHandler(this.Najazd);
			this.C2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C3
			// 
			this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C3.Location = new System.Drawing.Point(239, 268);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(100, 100);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = true;
			this.C3.Click += new System.EventHandler(this.przycisk_klik);
			this.C3.MouseEnter += new System.EventHandler(this.Najazd);
			this.C3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(27, 371);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 10;
			this.label1.Text = "Wygrane X";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(133, 371);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 11;
			this.label2.Text = "Remisy";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(239, 371);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 30);
			this.label3.TabIndex = 12;
			this.label3.Text = "Wygrane O";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// WygraneX
			// 
			this.WygraneX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.WygraneX.Location = new System.Drawing.Point(62, 405);
			this.WygraneX.Name = "WygraneX";
			this.WygraneX.Size = new System.Drawing.Size(25, 25);
			this.WygraneX.TabIndex = 13;
			this.WygraneX.Text = "0";
			this.WygraneX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Remis
			// 
			this.Remis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Remis.Location = new System.Drawing.Point(168, 405);
			this.Remis.Name = "Remis";
			this.Remis.Size = new System.Drawing.Size(25, 25);
			this.Remis.TabIndex = 14;
			this.Remis.Text = "0";
			this.Remis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WygraneO
			// 
			this.WygraneO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.WygraneO.Location = new System.Drawing.Point(276, 405);
			this.WygraneO.Name = "WygraneO";
			this.WygraneO.Size = new System.Drawing.Size(25, 25);
			this.WygraneO.TabIndex = 15;
			this.WygraneO.Text = "0";
			this.WygraneO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// kolej
			// 
			this.kolej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.kolej.Location = new System.Drawing.Point(27, 28);
			this.kolej.Name = "kolej";
			this.kolej.ReadOnly = true;
			this.kolej.Size = new System.Drawing.Size(312, 26);
			this.kolej.TabIndex = 16;
			this.kolej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::KiK.Resource.Siatka;
			this.ClientSize = new System.Drawing.Size(367, 441);
			this.Controls.Add(this.kolej);
			this.Controls.Add(this.WygraneO);
			this.Controls.Add(this.Remis);
			this.Controls.Add(this.WygraneX);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kółko i Krzyżyk";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
