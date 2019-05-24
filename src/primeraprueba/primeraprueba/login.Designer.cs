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
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ptbApp = new System.Windows.Forms.PictureBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIniciar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(259, 187);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContraseña.Location = new System.Drawing.Point(228, 256);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(120, 25);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // linkContraseña
            // 
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkContraseña.Location = new System.Drawing.Point(61, 407);
            this.linkContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(192, 25);
            this.linkContraseña.TabIndex = 3;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "Contraseña olvidada";
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlContraseña_LinkClicked);
            // 
            // btIniciar
            // 
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btIniciar.Location = new System.Drawing.Point(693, 399);
            this.btIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(133, 42);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(261, 55);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(340, 46);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "INICIAR SESIÓN";
            this.lblInicio.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(369, 187);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(369, 258);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(223, 22);
            this.txtContra.TabIndex = 7;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btRegistrar.Location = new System.Drawing.Point(400, 399);
            this.btRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(136, 42);
            this.btRegistrar.TabIndex = 8;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // pnlIniciar
            // 
            this.pnlIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIniciar.BackColor = System.Drawing.Color.White;
            this.pnlIniciar.Controls.Add(this.lblInicio);
            this.pnlIniciar.Controls.Add(this.btRegistrar);
            this.pnlIniciar.Controls.Add(this.lblNombre);
            this.pnlIniciar.Controls.Add(this.txtContra);
            this.pnlIniciar.Controls.Add(this.lblContraseña);
            this.pnlIniciar.Controls.Add(this.txtNombre);
            this.pnlIniciar.Controls.Add(this.linkContraseña);
            this.pnlIniciar.Controls.Add(this.btIniciar);
            this.pnlIniciar.Location = new System.Drawing.Point(424, 79);
            this.pnlIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlIniciar.Name = "pnlIniciar";
            this.pnlIniciar.Size = new System.Drawing.Size(888, 496);
            this.pnlIniciar.TabIndex = 9;
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlAmarillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmarillo.Location = new System.Drawing.Point(4, 4);
            this.pnlAmarillo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(1728, 6);
            this.pnlAmarillo.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.86824F));
            this.tableLayoutPanel1.Controls.Add(this.ptbApp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptbIcon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1736, 119);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // ptbApp
            // 
            this.ptbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbApp.Image = global::primeraprueba.Properties.Resources.letra;
            this.ptbApp.Location = new System.Drawing.Point(284, 4);
            this.ptbApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbApp.Name = "ptbApp";
            this.ptbApp.Size = new System.Drawing.Size(1448, 111);
            this.ptbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbApp.TabIndex = 25;
            this.ptbApp.TabStop = false;
            this.ptbApp.Click += new System.EventHandler(this.ptbApp_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbIcon.Image = global::primeraprueba.Properties.Resources.logo1;
            this.ptbIcon.Location = new System.Drawing.Point(72, 4);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(135, 107);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 22;
            this.ptbIcon.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnlAmarillo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlIniciar, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1736, 640);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1736, 759);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.Text = "login";
            this.pnlIniciar.ResumeLayout(false);
            this.pnlIniciar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ptbApp;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}