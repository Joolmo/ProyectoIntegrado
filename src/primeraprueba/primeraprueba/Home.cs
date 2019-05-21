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
        Base parent = null;

		public Home(Base par)
		{
			InitializeComponent();
            accesoURRv2.Titulo = "";
            accesoURRv1.Titulo = "";
            accesoURRv3.Titulo = "";
            accesoURRv4.Titulo = "";
            accesoURRv5.Titulo = "";
            accesoURRv6.Titulo = "";
            accesoURRv7.Titulo = "";
            accesoURRv8.Titulo = "";
            accesoURRv9.Titulo = "";
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;

        }

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}
		private void progressBar1_Click(object sender, EventArgs e){}
		private void label12_Click(object sender, EventArgs e) { }
		private void lblUsuDes4_Click(object sender, EventArgs e) { }


		private void btSesion_Click(object sender, EventArgs e)
		{

            parent.GoLogin();
			
		}

		private void btRegistro_Click(object sender, EventArgs e)
		{
            parent.GoRegistro();
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
            parent.GoRegistro(); 
        }

        private void accesoURRv2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbApp_Click(object sender, EventArgs e)
        {

        }
    }
}
