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
			this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nowaGraToolStripMenuItem,
			this.wyjścieToolStripMenuItem});
			this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.plikToolStripMenuItem.Text = "Plik";
			// 
			// nowaGraToolStripMenuItem
			// 
			this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
			this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.nowaGraToolStripMenuItem.Text = "Nowa Gra";
			this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.NowaGraToolStripMenuItemClick);
			// 
			// wyjścieToolStripMenuItem
			// 
			this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
			this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.wyjścieToolStripMenuItem.Text = "Wyjście";
			this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.WyjścieToolStripMenuItemClick);
			// 
			// pomocToolStripMenuItem
			// 
			this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.zasadyGryToolStripMenuItem,
			this.autorzyToolStripMenuItem});
			this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
			this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.pomocToolStripMenuItem.Text = "Pomoc";
			// 
			// zasadyGryToolStripMenuItem
			// 
			this.zasadyGryToolStripMenuItem.Name = "zasadyGryToolStripMenuItem";
			this.zasadyGryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.zasadyGryToolStripMenuItem.Text = "Zasady gry";
			this.zasadyGryToolStripMenuItem.Click += new System.EventHandler(this.ZasadyGryToolStripMenuItemClick);
			// 
			// autorzyToolStripMenuItem
			// 
			this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
			this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.autorzyToolStripMenuItem.Text = "Autorzy";
			this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.AutorzyToolStripMenuItemClick);
			// 
			// A1
			// 
			this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A1.Location = new System.Drawing.Point(25, 50);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(75, 75);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.przycisk_klik);
			this.A1.MouseEnter += new System.EventHandler(this.Najazd);
			this.A1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// A2
			// 
			this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A2.Location = new System.Drawing.Point(106, 50);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(75, 75);
			this.A2.TabIndex = 2;
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.przycisk_klik);
			this.A2.MouseEnter += new System.EventHandler(this.Najazd);
			this.A2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// A3
			// 
			this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.A3.Location = new System.Drawing.Point(187, 50);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(75, 75);
			this.A3.TabIndex = 3;
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.przycisk_klik);
			this.A3.MouseEnter += new System.EventHandler(this.Najazd);
			this.A3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B1
			// 
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B1.Location = new System.Drawing.Point(25, 131);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(75, 75);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.przycisk_klik);
			this.B1.MouseEnter += new System.EventHandler(this.Najazd);
			this.B1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B2
			// 
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B2.Location = new System.Drawing.Point(106, 131);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(75, 75);
			this.B2.TabIndex = 5;
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.przycisk_klik);
			this.B2.MouseEnter += new System.EventHandler(this.Najazd);
			this.B2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// B3
			// 
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B3.Location = new System.Drawing.Point(187, 131);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(75, 75);
			this.B3.TabIndex = 6;
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.przycisk_klik);
			this.B3.MouseEnter += new System.EventHandler(this.Najazd);
			this.B3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C1
			// 
			this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C1.Location = new System.Drawing.Point(25, 212);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(75, 75);
			this.C1.TabIndex = 7;
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.przycisk_klik);
			this.C1.MouseEnter += new System.EventHandler(this.Najazd);
			this.C1.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C2
			// 
			this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C2.Location = new System.Drawing.Point(106, 212);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(75, 75);
			this.C2.TabIndex = 8;
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.przycisk_klik);
			this.C2.MouseEnter += new System.EventHandler(this.Najazd);
			this.C2.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// C3
			// 
			this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C3.Location = new System.Drawing.Point(187, 212);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(75, 75);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = true;
			this.C3.Click += new System.EventHandler(this.przycisk_klik);
			this.C3.MouseEnter += new System.EventHandler(this.Najazd);
			this.C3.MouseLeave += new System.EventHandler(this.Zjazd);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 312);
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
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
