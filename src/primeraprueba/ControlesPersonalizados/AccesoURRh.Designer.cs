namespace ControlesPersonalizados
{
    partial class AccesoURRh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBot = new System.Windows.Forms.Label();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBot.Location = new System.Drawing.Point(4, 118);
            this.lblBot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(162, 61);
            this.lblBot.TabIndex = 0;
            this.lblBot.Text = "_";
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMid.Location = new System.Drawing.Point(4, 59);
            this.lblMid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(162, 59);
            this.lblMid.TabIndex = 1;
            this.lblMid.Text = "_";
            this.lblMid.Click += new System.EventHandler(this.lblMid_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Location = new System.Drawing.Point(4, 0);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(162, 59);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "_";
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(4, 4);
            this.picFoto.Margin = new System.Windows.Forms.Padding(4);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(258, 179);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 3;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picFoto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 187);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblTop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBot, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 179);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // AccesoURRh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccesoURRh";
            this.Size = new System.Drawing.Size(444, 187);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
