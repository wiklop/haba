/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2016-12-08
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KiK
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox gracz1;
		private System.Windows.Forms.TextBox gracz2;
		private System.Windows.Forms.Button Graj;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox logoKiK;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gracz1 = new System.Windows.Forms.TextBox();
			this.gracz2 = new System.Windows.Forms.TextBox();
			this.Graj = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.logoKiK = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.logoKiK)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(37, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gracz pierwszy";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(37, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gracz drugi";
			// 
			// gracz1
			// 
			this.gracz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gracz1.Location = new System.Drawing.Point(166, 238);
			this.gracz1.Name = "gracz1";
			this.gracz1.Size = new System.Drawing.Size(178, 26);
			this.gracz1.TabIndex = 2;
			this.gracz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gracz1);
			// 
			// gracz2
			// 
			this.gracz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gracz2.Location = new System.Drawing.Point(166, 273);
			this.gracz2.Name = "gracz2";
			this.gracz2.Size = new System.Drawing.Size(178, 26);
			this.gracz2.TabIndex = 3;
			this.gracz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gracz2KeyPress);
			// 
			// Graj
			// 
			this.Graj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Graj.Location = new System.Drawing.Point(253, 305);
			this.Graj.Name = "Graj";
			this.Graj.Size = new System.Drawing.Size(91, 39);
			this.Graj.TabIndex = 4;
			this.Graj.Text = "Graj";
			this.Graj.UseVisualStyleBackColor = true;
			this.Graj.Click += new System.EventHandler(this.GrajClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBox1.Location = new System.Drawing.Point(37, 306);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(168, 39);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Gra z Komputerem";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// logoKiK
			// 
			this.logoKiK.ImageLocation = "";
			this.logoKiK.InitialImage = global::KiK.Resource.Logo;
			this.logoKiK.Location = new System.Drawing.Point(25, 12);
			this.logoKiK.Name = "logoKiK";
			this.logoKiK.Size = new System.Drawing.Size(350, 180);
			this.logoKiK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.logoKiK.TabIndex = 6;
			this.logoKiK.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 357);
			this.Controls.Add(this.logoKiK);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Graj);
			this.Controls.Add(this.gracz2);
			this.Controls.Add(this.gracz1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(422, 395);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(422, 395);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kółko i Krzyżyk. Nazwij graczy";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.logoKiK)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

	
