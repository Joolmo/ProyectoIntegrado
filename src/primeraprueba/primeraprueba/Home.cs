using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeraprueba
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}
		private void progressBar1_Click(object sender, EventArgs e){}
		private void label12_Click(object sender, EventArgs e) { }
		private void lblUsuDes4_Click(object sender, EventArgs e) { }


		private void btSesion_Click(object sender, EventArgs e)
		{
			Hide();
			login log = new login();
			log.ShowDialog();
			
			
		}

		private void btRegistro_Click(object sender, EventArgs e)
		{
			Hide();
			Registrarse registro = new Registrarse();
			registro.ShowDialog();
		}

		private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSesion_Click_1(object sender, EventArgs e)
        {

        }

        private void btRegistro_Click_1(object sender, EventArgs e)
        {
            Hide();
            Registrarse reg = new Registrarse();
            reg.ShowDialog();
            
        }
    }
}
