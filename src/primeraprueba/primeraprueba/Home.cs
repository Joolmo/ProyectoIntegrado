using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesPersonalizados;

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
            RellenarRecetas();

            if (Usuario.UsuarioActual != null)
            {
                btRegistro.Hide();
                btSesion.Hide();
                picUsuario.Show();
                msDesplegable.Show();

                picUsuario.Image = Usuario.UsuarioActual.Foto;
            }
        }

        private void RellenarRecetas()
        {
            Random rnd = new Random();
            List<Receta> rec = Receta.GetRecetas();
            int i = rec.Count;
            foreach (Control con in Controls)
            {
                if(con.GetType() == accesoURRv1.GetType())
                {

                    int z = rnd.Next(0, i);
                    ((AccesoURRv) con).Titulo = rec[z].Nombre;
                    ((AccesoURRv)con).Foto = rec[z].Foto;
                    ((AccesoURRv)con).ID = rec[z].IdReceta;

                    ((AccesoURRv)con).Tipo = "Receta";
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}

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

        private void AccesoURRv2_MouseClick(object sender, MouseEventArgs e)
        {
            parent.GoReceta(Receta.GetReceta(accesoURRv2.ID));
        }

        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtIngles_Click(object sender, EventArgs e)
        {
            parent.GoReceta(Receta.GetReceta(accesoURRv2.ID));

        }

        private void accesoURRv2_Click(object sender, EventArgs e)
        {

        }

        private void accesoURRv2_Load(object sender, EventArgs e)
        {

        }

        private void accesoURRv2_DoubleClick(object sender, EventArgs e)
        {
            parent.GoReceta(Receta.GetReceta(17));
        }
    }
}
