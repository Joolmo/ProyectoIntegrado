namespace primeraprueba
{
	partial class Recetas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlCabecera = new System.Windows.Forms.Panel();
			this.ptbUsuario = new System.Windows.Forms.PictureBox();
			this.ptbIcon = new System.Windows.Forms.PictureBox();
			this.ptbFoto = new System.Windows.Forms.PictureBox();
			this.pnlComentarios = new System.Windows.Forms.Panel();
			this.lblComentario = new System.Windows.Forms.Label();
			this.lblNombreUsu = new System.Windows.Forms.Label();
			this.ptbComentario = new System.Windows.Forms.PictureBox();
			this.btENVIAR = new System.Windows.Forms.Button();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.tbcRecetas = new System.Windows.Forms.TabControl();
			this.tbpIngredientes = new System.Windows.Forms.TabPage();
			this.tbpPasos = new System.Windows.Forms.TabPage();
			this.lblRetoRecetas = new System.Windows.Forms.Label();
			this.lblnomusu = new System.Windows.Forms.Label();
			this.pnlCabecera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
			this.pnlComentarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbComentario)).BeginInit();
			this.tbcRecetas.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCabecera
			// 
			this.pnlCabecera.BackColor = System.Drawing.Color.DodgerBlue;
			this.pnlCabecera.Controls.Add(this.ptbUsuario);
			this.pnlCabecera.Controls.Add(this.ptbIcon);
			this.pnlCabecera.Location = new System.Drawing.Point(-1, -2);
			this.pnlCabecera.Name = "pnlCabecera";
			this.pnlCabecera.Size = new System.Drawing.Size(803, 94);
			this.pnlCabecera.TabIndex = 0;
			// 
			// ptbUsuario
			// 
			this.ptbUsuario.BackColor = System.Drawing.Color.White;
			this.ptbUsuario.Location = new System.Drawing.Point(698, 10);
			this.ptbUsuario.Name = "ptbUsuario";
			this.ptbUsuario.Size = new System.Drawing.Size(91, 75);
			this.ptbUsuario.TabIndex = 14;
			this.ptbUsuario.TabStop = false;
			// 
			// ptbIcon
			// 
			this.ptbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ptbIcon.Location = new System.Drawing.Point(13, 14);
			this.ptbIcon.Name = "ptbIcon";
			this.ptbIcon.Size = new System.Drawing.Size(63, 48);
			this.ptbIcon.TabIndex = 14;
			this.ptbIcon.TabStop = false;
			// 
			// ptbFoto
			// 
			this.ptbFoto.Location = new System.Drawing.Point(12, 113);
			this.ptbFoto.Name = "ptbFoto";
			this.ptbFoto.Size = new System.Drawing.Size(91, 75);
			this.ptbFoto.TabIndex = 12;
			this.ptbFoto.TabStop = false;
			// 
			// pnlComentarios
			// 
			this.pnlComentarios.BackColor = System.Drawing.Color.White;
			this.pnlComentarios.Controls.Add(this.lblComentario);
			this.pnlComentarios.Controls.Add(this.lblNombreUsu);
			this.pnlComentarios.Controls.Add(this.ptbComentario);
			this.pnlComentarios.Controls.Add(this.btENVIAR);
			this.pnlComentarios.Controls.Add(this.txtComentario);
			this.pnlComentarios.Location = new System.Drawing.Point(462, 138);
			this.pnlComentarios.Name = "pnlComentarios";
			this.pnlComentarios.Size = new System.Drawing.Size(288, 110);
			this.pnlComentarios.TabIndex = 13;
			// 
			// lblComentario
			// 
			this.lblComentario.AutoSize = true;
			this.lblComentario.Location = new System.Drawing.Point(96, 36);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(60, 13);
			this.lblComentario.TabIndex = 17;
			this.lblComentario.Text = "Comentario";
			// 
			// lblNombreUsu
			// 
			this.lblNombreUsu.AutoSize = true;
			this.lblNombreUsu.Location = new System.Drawing.Point(93, 13);
			this.lblNombreUsu.Name = "lblNombreUsu";
			this.lblNombreUsu.Size = new System.Drawing.Size(83, 13);
			this.lblNombreUsu.TabIndex = 16;
			this.lblNombreUsu.Text = "Nombre Usuario";
			// 
			// ptbComentario
			// 
			this.ptbComentario.Location = new System.Drawing.Point(11, 13);
			this.ptbComentario.Name = "ptbComentario";
			this.ptbComentario.Size = new System.Drawing.Size(65, 59);
			this.ptbComentario.TabIndex = 15;
			this.ptbComentario.TabStop = false;
			this.ptbComentario.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btENVIAR
			// 
			this.btENVIAR.Location = new System.Drawing.Point(210, 81);
			this.btENVIAR.Name = "btENVIAR";
			this.btENVIAR.Size = new System.Drawing.Size(75, 23);
			this.btENVIAR.TabIndex = 1;
			this.btENVIAR.Text = "ENVIAR";
			this.btENVIAR.UseVisualStyleBackColor = true;
			// 
			// txtComentario
			// 
			this.txtComentario.Location = new System.Drawing.Point(0, 84);
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(204, 20);
			this.txtComentario.TabIndex = 0;
			// 
			// tbcRecetas
			// 
			this.tbcRecetas.Controls.Add(this.tbpIngredientes);
			this.tbcRecetas.Controls.Add(this.tbpPasos);
			this.tbcRecetas.Location = new System.Drawing.Point(462, 254);
			this.tbcRecetas.Name = "tbcRecetas";
			this.tbcRecetas.SelectedIndex = 0;
			this.tbcRecetas.Size = new System.Drawing.Size(288, 184);
			this.tbcRecetas.TabIndex = 14;
			// 
			// tbpIngredientes
			// 
			this.tbpIngredientes.Location = new System.Drawing.Point(4, 22);
			this.tbpIngredientes.Name = "tbpIngredientes";
			this.tbpIngredientes.Padding = new System.Windows.Forms.Padding(3);
			this.tbpIngredientes.Size = new System.Drawing.Size(280, 158);
			this.tbpIngredientes.TabIndex = 0;
			this.tbpIngredientes.Text = "Ingredientes";
			this.tbpIngredientes.UseVisualStyleBackColor = true;
			// 
			// tbpPasos
			// 
			this.tbpPasos.Location = new System.Drawing.Point(4, 22);
			this.tbpPasos.Name = "tbpPasos";
			this.tbpPasos.Padding = new System.Windows.Forms.Padding(3);
			this.tbpPasos.Size = new System.Drawing.Size(280, 158);
			this.tbpPasos.TabIndex = 1;
			this.tbpPasos.Text = "Pasos";
			this.tbpPasos.UseVisualStyleBackColor = true;
			// 
			// lblRetoRecetas
			// 
			this.lblRetoRecetas.AutoSize = true;
			this.lblRetoRecetas.Location = new System.Drawing.Point(136, 138);
			this.lblRetoRecetas.Name = "lblRetoRecetas";
			this.lblRetoRecetas.Size = new System.Drawing.Size(110, 13);
			this.lblRetoRecetas.TabIndex = 15;
			this.lblRetoRecetas.Text = "Nombre Receta/Reto";
			// 
			// lblnomusu
			// 
			this.lblnomusu.AutoSize = true;
			this.lblnomusu.Location = new System.Drawing.Point(136, 113);
			this.lblnomusu.Name = "lblnomusu";
			this.lblnomusu.Size = new System.Drawing.Size(83, 13);
			this.lblnomusu.TabIndex = 16;
			this.lblnomusu.Text = "Nombre Usuario";
			// 
			// Recetas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblnomusu);
			this.Controls.Add(this.lblRetoRecetas);
			this.Controls.Add(this.tbcRecetas);
			this.Controls.Add(this.pnlComentarios);
			this.Controls.Add(this.ptbFoto);
			this.Controls.Add(this.pnlCabecera);
			this.Name = "Recetas";
			this.Text = "Recetas";
			this.pnlCabecera.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
			this.pnlComentarios.ResumeLayout(false);
			this.pnlComentarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbComentario)).EndInit();
			this.tbcRecetas.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlCabecera;
		private System.Windows.Forms.PictureBox ptbIcon;
		private System.Windows.Forms.PictureBox ptbUsuario;
		private System.Windows.Forms.PictureBox ptbFoto;
		private System.Windows.Forms.Panel pnlComentarios;
		private System.Windows.Forms.Button btENVIAR;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TabControl tbcRecetas;
		private System.Windows.Forms.TabPage tbpIngredientes;
		private System.Windows.Forms.TabPage tbpPasos;
		private System.Windows.Forms.PictureBox ptbComentario;
		private System.Windows.Forms.Label lblComentario;
		private System.Windows.Forms.Label lblNombreUsu;
		private System.Windows.Forms.Label lblRetoRecetas;
		private System.Windows.Forms.Label lblnomusu;
	}
}