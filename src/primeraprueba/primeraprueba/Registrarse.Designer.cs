namespace primeraprueba
{
	partial class Registrarse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.linkIniciar = new System.Windows.Forms.LinkLabel();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtConfirContra = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblConfirContra = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ptbApp = new System.Windows.Forms.PictureBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegistro.BackColor = System.Drawing.Color.White;
            this.pnlRegistro.Controls.Add(this.lblDesc);
            this.pnlRegistro.Controls.Add(this.btnModificar);
            this.pnlRegistro.Controls.Add(this.btRegistrar);
            this.pnlRegistro.Controls.Add(this.linkIniciar);
            this.pnlRegistro.Controls.Add(this.ptbImagen);
            this.pnlRegistro.Controls.Add(this.txtCorreo);
            this.pnlRegistro.Controls.Add(this.txtConfirContra);
            this.pnlRegistro.Controls.Add(this.txtContra);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.lblConfirContra);
            this.pnlRegistro.Controls.Add(this.lblCorreo);
            this.pnlRegistro.Controls.Add(this.lblContra);
            this.pnlRegistro.Controls.Add(this.lblNombre);
            this.pnlRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistro.ForeColor = System.Drawing.Color.White;
            this.pnlRegistro.Location = new System.Drawing.Point(331, 80);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(916, 425);
            this.pnlRegistro.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(385, 335);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 49);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btRegistrar.Location = new System.Drawing.Point(385, 335);
            this.btRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(173, 49);
            this.btRegistrar.TabIndex = 12;
            this.btRegistrar.Text = "Registrarse";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkIniciar
            // 
            this.linkIniciar.AutoSize = true;
            this.linkIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkIniciar.Location = new System.Drawing.Point(203, 347);
            this.linkIniciar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkIniciar.Name = "linkIniciar";
            this.linkIniciar.Size = new System.Drawing.Size(129, 25);
            this.linkIniciar.TabIndex = 11;
            this.linkIniciar.TabStop = true;
            this.linkIniciar.Text = "Iniciar Sesión";
            this.linkIniciar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
            this.ptbImagen.Location = new System.Drawing.Point(624, 62);
            this.ptbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(239, 212);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagen.TabIndex = 10;
            this.ptbImagen.TabStop = false;
            this.ptbImagen.Click += new System.EventHandler(this.ptbImagen_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(351, 249);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(207, 23);
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtConfirContra
            // 
            this.txtConfirContra.Location = new System.Drawing.Point(351, 191);
            this.txtConfirContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirContra.Name = "txtConfirContra";
            this.txtConfirContra.PasswordChar = '*';
            this.txtConfirContra.Size = new System.Drawing.Size(207, 23);
            this.txtConfirContra.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(351, 133);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(207, 23);
            this.txtContra.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(351, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // lblConfirContra
            // 
            this.lblConfirContra.AutoSize = true;
            this.lblConfirContra.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirContra.ForeColor = System.Drawing.Color.Black;
            this.lblConfirContra.Location = new System.Drawing.Point(101, 188);
            this.lblConfirContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirContra.Name = "lblConfirContra";
            this.lblConfirContra.Size = new System.Drawing.Size(282, 25);
            this.lblConfirContra.TabIndex = 4;
            this.lblConfirContra.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(130, 246);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(104, 25);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "CORREO:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Black;
            this.lblContra.Location = new System.Drawing.Point(203, 133);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(158, 25);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "CONTRASEÑA:";
            this.lblContra.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(239, 77);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlAmarillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmarillo.Location = new System.Drawing.Point(4, 4);
            this.pnlAmarillo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(1571, 6);
            this.pnlAmarillo.TabIndex = 30;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1579, 119);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // ptbApp
            // 
            this.ptbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbApp.Image = ((System.Drawing.Image)(resources.GetObject("ptbApp.Image")));
            this.ptbApp.Location = new System.Drawing.Point(258, 4);
            this.ptbApp.Margin = new System.Windows.Forms.Padding(4);
            this.ptbApp.Name = "ptbApp";
            this.ptbApp.Size = new System.Drawing.Size(1317, 111);
            this.ptbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbApp.TabIndex = 25;
            this.ptbApp.TabStop = false;
            this.ptbApp.Click += new System.EventHandler(this.ptbApp_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbIcon.Image = ((System.Drawing.Image)(resources.GetObject("ptbIcon.Image")));
            this.ptbIcon.Location = new System.Drawing.Point(59, 4);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(4);
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
            this.tableLayoutPanel2.Controls.Add(this.pnlRegistro, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1579, 571);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(185, 79);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 25);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "DESCRIPCION:";
            this.lblDesc.Visible = false;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlRegistro;
		private System.Windows.Forms.Label lblConfirContra;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Label lblContra;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtConfirContra;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Button btRegistrar;
		private System.Windows.Forms.LinkLabel linkIniciar;
		private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ptbApp;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDesc;
    }
}