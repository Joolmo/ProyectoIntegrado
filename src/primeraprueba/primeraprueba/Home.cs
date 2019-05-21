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

            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            accesoURRv2.Titulo = "";
            accesoURRv1.Titulo = "";
            accesoURRv3.Titulo = "";
            accesoURRv4.Titulo = "";
            accesoURRv5.Titulo = "";
            accesoURRv6.Titulo = "";
            accesoURRv7.Titulo = "";
            accesoURRv8.Titulo = "";
            accesoURRv9.Titulo = "";

            if (Usuario.UsuarioActual != null)
            {
                btRegistro.Hide();
                btSesion.Hide();
                picUsuario.Show();
                msDesplegable.Show();

                picUsuario.Image = Usuario.UsuarioActual.Foto;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}
		private void progressBar1_Click(object sender, EventArgs e){}
		private void label12_Click(object sender, EventArgs e) { }
		private void lblUsuDes4_Click(object sender, EventArgs e) { }

		private void btRegistro_Click(object sender, EventArgs e)
		{
            parent.GoRegistro();
		}

        private void btSesion_Click_1(object sender, EventArgs e)
        {
            parent.GoLogin();
        }

        private void btRegistro_Click_1(object sender, EventArgs e)
        {
            parent.GoRegistro(); 
        }

        private void PicUsuario_Click(object sender, EventArgs e)
        {
            msDesplegable.BringToFront();
        }

        private void RecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.GoCrearReceta();
        }

        private void PtbApp_Click(object sender, EventArgs e)
        {

        }
    }
}
