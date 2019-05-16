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
            this.pnlIniciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(236, 155);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(228, 213);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // linkContraseña
            // 
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.Location = new System.Drawing.Point(154, 313);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(104, 13);
            this.linkContraseña.TabIndex = 3;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "Contraseña olvidada";
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlContraseña_LinkClicked);
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(422, 308);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(226, 80);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(184, 25);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "INICIAR SESIÓN";
            this.lblInicio.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(295, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(295, 210);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 7;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(295, 308);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
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
            this.pnlIniciar.Location = new System.Drawing.Point(285, 124);
            this.pnlIniciar.Name = "pnlIniciar";
            this.pnlIniciar.Size = new System.Drawing.Size(671, 428);
            this.pnlIniciar.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.pnlIniciar);
            this.Name = "login";
            this.Text = "login";
            this.pnlIniciar.ResumeLayout(false);
            this.pnlIniciar.PerformLayout();
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
    }
}