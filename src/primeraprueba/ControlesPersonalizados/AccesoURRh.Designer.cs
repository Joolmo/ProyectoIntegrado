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
            this.lblInfoBot = new System.Windows.Forms.Label();
            this.lblInfoMid = new System.Windows.Forms.Label();
            this.lblInfoTop = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoBot
            // 
            this.lblInfoBot.AutoSize = true;
            this.lblInfoBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoBot.Location = new System.Drawing.Point(3, 96);
            this.lblInfoBot.Name = "lblInfoBot";
            this.lblInfoBot.Size = new System.Drawing.Size(122, 50);
            this.lblInfoBot.TabIndex = 0;
            this.lblInfoBot.Text = "label1";
            // 
            // lblInfoMid
            // 
            this.lblInfoMid.AutoSize = true;
            this.lblInfoMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoMid.Location = new System.Drawing.Point(3, 48);
            this.lblInfoMid.Name = "lblInfoMid";
            this.lblInfoMid.Size = new System.Drawing.Size(122, 48);
            this.lblInfoMid.TabIndex = 1;
            this.lblInfoMid.Text = "label2";
            // 
            // lblInfoTop
            // 
            this.lblInfoTop.AutoSize = true;
            this.lblInfoTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoTop.Location = new System.Drawing.Point(3, 0);
            this.lblInfoTop.Name = "lblInfoTop";
            this.lblInfoTop.Size = new System.Drawing.Size(122, 48);
            this.lblInfoTop.TabIndex = 2;
            this.lblInfoTop.Text = "label3";
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(3, 3);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(193, 146);
            this.picFoto.TabIndex = 3;
            this.picFoto.TabStop = false;
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 152);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblInfoTop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblInfoMid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInfoBot, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(202, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 146);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // AccesoURRh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccesoURRh";
            this.Size = new System.Drawing.Size(333, 152);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfoBot;
        private System.Windows.Forms.Label lblInfoMid;
        private System.Windows.Forms.Label lblInfoTop;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
