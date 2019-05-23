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
using primeraprueba.RecursosLocalizables;
using System.Globalization;
using System.Threading;


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
            RellenarRecetas(Receta.GetRecetas());
            RellenarUsuarios(Usuario.GetUsuarios());

            if (Usuario.UsuarioActual != null)
            {
                btRegistro.Hide();
                btSesion.Hide();
                picUsuario.Show();
                msDesplegable.Show();

                picUsuario.Image = Usuario.UsuarioActual.Foto;
            }
        }

        private void RellenarRecetas(List<Receta> rec)
        {
            Random rnd = new Random();
            int i = rec.Count;
            List<int> usados = new List<int>();

            foreach (Control con in tableLayoutPanel4.Controls)
            {
                if(con.GetType() == accesoURRv1.GetType())
                {

                    if (i <= usados.Count)
                        break;

                    int z = 0;
                    do
                    {
                        z = rnd.Next(0, i);
                    } while (usados.Where(x => x == z).ToList().Count != 0);

                    usados.Add(z);

                    ((AccesoURRv) con).Titulo = rec[z].Nombre;
                    ((AccesoURRv)con).Foto = rec[z].Foto;
                    ((AccesoURRv)con).ID = rec[z].IdReceta;
                    ((AccesoURRv)con).Tipo = "Receta";
                    ((AccesoURRv)con).CualquierClick += (object sender, EventArgs e) =>
                    {
                        parent.GoReceta(Receta.GetReceta(((AccesoURRv)con).ID));
                    };
                }
            }

        }

        private void Clear()
        {
            foreach (Control con in tableLayoutPanel4.Controls)
            {
                if (con.GetType() == accesoURRv1.GetType())
                {
                    ((AccesoURRv)con).Titulo = "";
                    ((AccesoURRv)con).Foto = null;
                    ((AccesoURRv)con).ID = 0;
                    ((AccesoURRv)con).Tipo = "";
                    //foreach (Delegate d in ((AccesoURRv)con).CualquierClick.GetInvocationList())
                    //{
                    //    FindClicked -= (FindClickedHandler)d;
                    //}
                }
            }
        }

        private void RellenarUsuarios(List<Usuario> usu)
        {
            Random rnd = new Random();
            int i = usu.Count;
            List<int> usados = new List<int>();

            foreach (Control con in tableLayoutPanel5.Controls)
            {
                if (con.GetType() == accesoURRv1.GetType())
                {
                    if (i <= usados.Count)
                        break;

                    int z = 0;
                    do
                    {
                        z = rnd.Next(0, i);
                    } while (usados.Where(x => x == z).ToList().Count != 0);
                    
                    usados.Add(z);

                    ((AccesoURRv)con).Titulo = usu[z].Nombre;
                    ((AccesoURRv)con).Foto = usu[z].Foto;
                    ((AccesoURRv)con).ID = usu[z].ID_Usuario;
                    ((AccesoURRv)con).Tipo = "Usaurio";
                    ((AccesoURRv)con).CualquierClick += (object sender, EventArgs e) =>
                    {
                        parent.GoUsuario(Usuario.GetUsuario(((AccesoURRv)con).ID));
                    };
                }
            }

        }

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


        private void AccesoURRv2_MouseClick(object sender, MouseEventArgs e)
        {
            parent.GoReceta(Receta.GetReceta(accesoURRv2.ID));
        }

        private void BtIngles_Click(object sender, EventArgs e)
        {
            parent.GoReceta(Receta.GetReceta(accesoURRv2.ID));

        }

        private void TxtDireccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clear();
            RellenarRecetas(Buscador.BuscarRecetas(txtDireccion.Text));
        }

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cmbIdioma.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "Inglés":
                    {
                        cultura = "EN-GB";  // Inglés United Kingdom
                        break;
                    }
                case "Italiano":
                    {
                        cultura = "IT-IT";  // Inglés United Kingdom
                        break;
                    }

            }
            //MessageBox.Show("Nombre de la referencia cultural en .NET: "+cultura);  // mensaje informativo
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            //AplicarIdioma();
        }

        /*private void AplicarIdioma()
        {
            lblDirección.Text = StringRecursos.
        }*/
    }
}
