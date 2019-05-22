namespace primeraprueba
{
	partial class CrearReceta
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
            this.picFotoUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.lblInsertarImagen = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ptbApp = new System.Windows.Forms.PictureBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnAnyadirTag = new System.Windows.Forms.Button();
            this.btnEliminarTag = new System.Windows.Forms.Button();
            this.tgsTags = new ControlesPersonalizados.Tags();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFotoUsuario
            // 
            this.picFotoUsuario.Location = new System.Drawing.Point(16, 3);
            this.picFotoUsuario.Name = "picFotoUsuario";
            this.picFotoUsuario.Size = new System.Drawing.Size(109, 90);
            this.picFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUsuario.TabIndex = 34;
            this.picFotoUsuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNombreReceta);
            this.panel1.Controls.Add(this.txtNombreReceta);
            this.panel1.Controls.Add(this.btnEliminarTag);
            this.panel1.Controls.Add(this.btnAnyadirTag);
            this.panel1.Controls.Add(this.txtTag);
            this.panel1.Controls.Add(this.tgsTags);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btEnviar);
            this.panel1.Controls.Add(this.txtIngredientes);
            this.panel1.Controls.Add(this.lblIngredientes);
            this.panel1.Controls.Add(this.txtPasos);
            this.panel1.Controls.Add(this.lblPasos);
            this.panel1.Controls.Add(this.lblInsertarImagen);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.picFoto);
            this.panel1.Controls.Add(this.picFotoUsuario);
            this.panel1.Location = new System.Drawing.Point(94, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 447);
            this.panel1.TabIndex = 35;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(705, 401);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(141, 34);
            this.btCancelar.TabIndex = 43;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(852, 400);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(141, 35);
            this.btEnviar.TabIndex = 42;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(643, 252);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(379, 122);
            this.txtIngredientes.TabIndex = 41;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(638, 220);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(147, 29);
            this.lblIngredientes.TabIndex = 40;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(643, 56);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(379, 128);
            this.txtPasos.TabIndex = 39;
            this.txtPasos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasos.Location = new System.Drawing.Point(638, 17);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(172, 29);
            this.lblPasos.TabIndex = 38;
            this.lblPasos.Text = "Pasos a seguir";
            // 
            // lblInsertarImagen
            // 
            this.lblInsertarImagen.AutoSize = true;
            this.lblInsertarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertarImagen.Location = new System.Drawing.Point(11, 96);
            this.lblInsertarImagen.Name = "lblInsertarImagen";
            this.lblInsertarImagen.Size = new System.Drawing.Size(179, 29);
            this.lblInsertarImagen.TabIndex = 37;
            this.lblInsertarImagen.Text = "Insertar Imagen";
            this.lblInsertarImagen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(131, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(172, 29);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario propio";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(16, 128);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(308, 227);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 35;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // tableLayoutPanel2
            // 
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1238, 97);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // ptbApp
            // 
            this.ptbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbApp.Image = global::primeraprueba.Properties.Resources.letra;
            this.ptbApp.Location = new System.Drawing.Point(202, 3);
            this.ptbApp.Name = "ptbApp";
            this.ptbApp.Size = new System.Drawing.Size(1033, 91);
            this.ptbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbApp.TabIndex = 25;
            this.ptbApp.TabStop = false;
            // 
            // ptbIcon
            // 
            this.ptbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbIcon.Image = global::primeraprueba.Properties.Resources.logo1;
            this.ptbIcon.Location = new System.Drawing.Point(49, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(101, 87);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 22;
            this.ptbIcon.TabStop = false;
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlAmarillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmarillo.Location = new System.Drawing.Point(3, 3);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(1232, 5);
            this.pnlAmarillo.TabIndex = 33;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pnlAmarillo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 97);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1238, 564);
            this.tableLayoutPanel3.TabIndex = 42;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel3_Paint);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(16, 400);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(206, 20);
            this.txtTag.TabIndex = 47;
            // 
            // btnAnyadirTag
            // 
            this.btnAnyadirTag.Location = new System.Drawing.Point(228, 397);
            this.btnAnyadirTag.Name = "btnAnyadirTag";
            this.btnAnyadirTag.Size = new System.Drawing.Size(75, 23);
            this.btnAnyadirTag.TabIndex = 48;
            this.btnAnyadirTag.Text = "Añadir tag";
            this.btnAnyadirTag.UseVisualStyleBackColor = true;
            this.btnAnyadirTag.Click += new System.EventHandler(this.BtnAnyadirTag_Click);
            // 
            // btnEliminarTag
            // 
            this.btnEliminarTag.Location = new System.Drawing.Point(314, 397);
            this.btnEliminarTag.Name = "btnEliminarTag";
            this.btnEliminarTag.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTag.TabIndex = 49;
            this.btnEliminarTag.Text = "Eliminar tag";
            this.btnEliminarTag.UseVisualStyleBackColor = true;
            this.btnEliminarTag.Click += new System.EventHandler(this.BtnEliminarTag_Click);
            // 
            // tgsTags
            // 
            this.tgsTags.Location = new System.Drawing.Point(16, 360);
            this.tgsTags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tgsTags.Name = "tgsTags";
            this.tgsTags.Size = new System.Drawing.Size(373, 32);
            this.tgsTags.TabIndex = 46;
            this.tgsTags.Load += new System.EventHandler(this.Tags2_Load);
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(136, 73);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreReceta.TabIndex = 50;
            this.txtNombreReceta.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Location = new System.Drawing.Point(136, 56);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(80, 13);
            this.lblNombreReceta.TabIndex = 51;
            this.lblNombreReceta.Text = "Nombre receta:";
            this.lblNombreReceta.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CrearReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1238, 661);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CrearReceta";
            this.Text = "CrearReceta";
            this.Load += new System.EventHandler(this.CrearReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox picFotoUsuario;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picFoto;
		private System.Windows.Forms.TextBox txtPasos;
		private System.Windows.Forms.Label lblPasos;
		private System.Windows.Forms.Label lblInsertarImagen;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Button btEnviar;
		private System.Windows.Forms.TextBox txtIngredientes;
		private System.Windows.Forms.Label lblIngredientes;
		private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox ptbApp;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ControlesPersonalizados.Tags tgsTags;
        private System.Windows.Forms.Button btnEliminarTag;
        private System.Windows.Forms.Button btnAnyadirTag;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label lblNombreReceta;
    }
}