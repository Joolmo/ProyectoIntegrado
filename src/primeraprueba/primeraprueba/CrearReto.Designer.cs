namespace primeraprueba
{
	partial class CrearReto
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ptbApp = new System.Windows.Forms.PictureBox();
			this.ptbIcon = new System.Windows.Forms.PictureBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblDescripción = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblFechaini = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.btEnviar = new System.Windows.Forms.Button();
			this.btCancelar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlAmarillo = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbApp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.DodgerBlue;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13176F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.86824F));
			this.tableLayoutPanel2.Controls.Add(this.ptbApp, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ptbIcon, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1184, 97);
			this.tableLayoutPanel2.TabIndex = 42;
			// 
			// ptbApp
			// 
			this.ptbApp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptbApp.Image = global::primeraprueba.Properties.Resources.letra;
			this.ptbApp.Location = new System.Drawing.Point(194, 3);
			this.ptbApp.Name = "ptbApp";
			this.ptbApp.Size = new System.Drawing.Size(987, 91);
			this.ptbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ptbApp.TabIndex = 25;
			this.ptbApp.TabStop = false;
			// 
			// ptbIcon
			// 
			this.ptbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ptbIcon.Image = global::primeraprueba.Properties.Resources.logo1;
			this.ptbIcon.Location = new System.Drawing.Point(45, 3);
			this.ptbIcon.Name = "ptbIcon";
			this.ptbIcon.Size = new System.Drawing.Size(101, 87);
			this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbIcon.TabIndex = 22;
			this.ptbIcon.TabStop = false;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(78, 14);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(69, 20);
			this.lblNombre.TabIndex = 43;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(153, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(128, 20);
			this.txtNombre.TabIndex = 44;
			// 
			// lblDescripción
			// 
			this.lblDescripción.AutoSize = true;
			this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripción.Location = new System.Drawing.Point(78, 57);
			this.lblDescripción.Name = "lblDescripción";
			this.lblDescripción.Size = new System.Drawing.Size(96, 20);
			this.lblDescripción.TabIndex = 45;
			this.lblDescripción.Text = "Descripción:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(82, 80);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(823, 215);
			this.textBox1.TabIndex = 46;
			// 
			// lblFechaini
			// 
			this.lblFechaini.AutoSize = true;
			this.lblFechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaini.Location = new System.Drawing.Point(78, 315);
			this.lblFechaini.Name = "lblFechaini";
			this.lblFechaini.Size = new System.Drawing.Size(97, 20);
			this.lblFechaini.TabIndex = 47;
			this.lblFechaini.Text = "Fecha inicio:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(78, 351);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Fecha final:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(181, 315);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 49;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(180, 351);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 50;
			// 
			// btEnviar
			// 
			this.btEnviar.Location = new System.Drawing.Point(82, 395);
			this.btEnviar.Name = "btEnviar";
			this.btEnviar.Size = new System.Drawing.Size(93, 37);
			this.btEnviar.TabIndex = 51;
			this.btEnviar.Text = "Enviar";
			this.btEnviar.UseVisualStyleBackColor = true;
			// 
			// btCancelar
			// 
			this.btCancelar.Location = new System.Drawing.Point(288, 395);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(93, 37);
			this.btCancelar.TabIndex = 52;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pnlAmarillo);
			this.panel1.Controls.Add(this.lblNombre);
			this.panel1.Controls.Add(this.btCancelar);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.lblFechaini);
			this.panel1.Controls.Add(this.btEnviar);
			this.panel1.Controls.Add(this.lblDescripción);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1184, 464);
			this.panel1.TabIndex = 53;
			// 
			// pnlAmarillo
			// 
			this.pnlAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pnlAmarillo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAmarillo.Location = new System.Drawing.Point(0, 0);
			this.pnlAmarillo.Name = "pnlAmarillo";
			this.pnlAmarillo.Size = new System.Drawing.Size(1184, 5);
			this.pnlAmarillo.TabIndex = 53;
			// 
			// CrearReto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "CrearReto";
			this.Text = "CrearReto";
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbApp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox ptbApp;
		private System.Windows.Forms.PictureBox ptbIcon;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblDescripción;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblFechaini;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button btEnviar;
		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlAmarillo;
	}
}