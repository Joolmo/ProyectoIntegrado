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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.linlContraseña = new System.Windows.Forms.LinkLabel();
			this.btIniciar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btRegistrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(172, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(423, 290);
			this.listBox1.TabIndex = 0;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(290, 164);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre";
			// 
			// lblContraseña
			// 
			this.lblContraseña.AutoSize = true;
			this.lblContraseña.Location = new System.Drawing.Point(282, 222);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(61, 13);
			this.lblContraseña.TabIndex = 2;
			this.lblContraseña.Text = "Contraseña";
			// 
			// linlContraseña
			// 
			this.linlContraseña.AutoSize = true;
			this.linlContraseña.Location = new System.Drawing.Point(208, 322);
			this.linlContraseña.Name = "linlContraseña";
			this.linlContraseña.Size = new System.Drawing.Size(104, 13);
			this.linlContraseña.TabIndex = 3;
			this.linlContraseña.TabStop = true;
			this.linlContraseña.Text = "Contraseña olvidada";
			// 
			// btIniciar
			// 
			this.btIniciar.Location = new System.Drawing.Point(476, 317);
			this.btIniciar.Name = "btIniciar";
			this.btIniciar.Size = new System.Drawing.Size(75, 23);
			this.btIniciar.TabIndex = 4;
			this.btIniciar.Text = "Iniciar";
			this.btIniciar.UseVisualStyleBackColor = true;
			this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(280, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "INICIAR SESIÓN";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(349, 161);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(349, 219);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 7;
			// 
			// btRegistrar
			// 
			this.btRegistrar.Location = new System.Drawing.Point(349, 317);
			this.btRegistrar.Name = "btRegistrar";
			this.btRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btRegistrar.TabIndex = 8;
			this.btRegistrar.Text = "Registrar";
			this.btRegistrar.UseVisualStyleBackColor = true;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btRegistrar);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btIniciar);
			this.Controls.Add(this.linlContraseña);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.listBox1);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.LinkLabel linlContraseña;
		private System.Windows.Forms.Button btIniciar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btRegistrar;
	}
}