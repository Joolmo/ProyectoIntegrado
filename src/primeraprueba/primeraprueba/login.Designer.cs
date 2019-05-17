namespace primeraprueba
{
	partial class login
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.btIniciar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.pnlIniciar = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.ptbApp = new System.Windows.Forms.PictureBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.pnlIniciar.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(194, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContraseña.Location = new System.Drawing.Point(171, 208);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // linkContraseña
            // 
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkContraseña.Location = new System.Drawing.Point(47, 324);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(154, 20);
            this.linkContraseña.TabIndex = 3;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "Contraseña olvidada";
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlContraseña_LinkClicked);
            // 
            // btIniciar
            // 
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btIniciar.Location = new System.Drawing.Point(491, 317);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(100, 34);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(196, 45);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(275, 37);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "INICIAR SESIÓN";
            this.lblInicio.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(277, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(277, 210);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(168, 20);
            this.txtContra.TabIndex = 7;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btRegistrar.Location = new System.Drawing.Point(287, 317);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(102, 34);
            this.btRegistrar.TabIndex = 8;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // pnlIniciar
            // 
            this.pnlIniciar.BackColor = System.Drawing.Color.White;
            this.pnlIniciar.Controls.Add(this.lblInicio);
            this.pnlIniciar.Controls.Add(this.btRegistrar);
            this.pnlIniciar.Controls.Add(this.lblNombre);
            this.pnlIniciar.Controls.Add(this.txtContra);
            this.pnlIniciar.Controls.Add(this.lblContraseña);
            this.pnlIniciar.Controls.Add(this.txtNombre);
            this.pnlIniciar.Controls.Add(this.linkContraseña);
            this.pnlIniciar.Controls.Add(this.btIniciar);
            this.pnlIniciar.Location = new System.Drawing.Point(265, 132);
            this.pnlIniciar.Name = "pnlIniciar";
            this.pnlIniciar.Size = new System.Drawing.Size(666, 403);
            this.pnlIniciar.TabIndex = 9;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlCabecera.Controls.Add(this.ptbApp);
            this.pnlCabecera.Controls.Add(this.ptbIcon);
            this.pnlCabecera.Location = new System.Drawing.Point(1, 1);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1182, 95);
            this.pnlCabecera.TabIndex = 30;
            // 
            // ptbApp
            // 
            this.ptbApp.Image = global::primeraprueba.Properties.Resources.letra;
            this.ptbApp.Location = new System.Drawing.Point(402, 0);
            this.ptbApp.Name = "ptbApp";
            this.ptbApp.Size = new System.Drawing.Size(367, 88);
            this.ptbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbApp.TabIndex = 25;
            this.ptbApp.TabStop = false;
            // 
            // ptbIcon
            // 
            this.ptbIcon.Image = global::primeraprueba.Properties.Resources.logo1;
            this.ptbIcon.Location = new System.Drawing.Point(108, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(101, 87);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 22;
            this.ptbIcon.TabStop = false;
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlAmarillo.Location = new System.Drawing.Point(1, 97);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(1179, 5);
            this.pnlAmarillo.TabIndex = 31;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlAmarillo);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlIniciar);
            this.Name = "login";
            this.Text = "login";
            this.pnlIniciar.ResumeLayout(false);
            this.pnlIniciar.PerformLayout();
            this.pnlCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.LinkLabel linkContraseña;
		private System.Windows.Forms.Button btIniciar;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Panel pnlIniciar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.PictureBox ptbApp;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Panel pnlAmarillo;
    }
}