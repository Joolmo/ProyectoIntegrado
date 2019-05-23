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
	public partial class UsuarioInterfaz : Form
	{
        Usuario u;
        Base parent = null;
        public UsuarioInterfaz(Base par, Usuario usu)
		{
			InitializeComponent();
            u = usu;
            RellenarRecetas(Receta.GetRecetas(usu.ID_Usuario));
            
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
            //lblnseg.Text = Usuario.Cont_NumSeguidores(usu.ID_Usuario).ToString();
            ptbUsu.Image = usu.Foto;
            lblNomUsu.Text = usu.Nombre;
            lblDescrip.Text = usu.Descripcion;
            

            
        }

		private void pictureBox10_Click(object sender, EventArgs e){}
		private void pictureBox9_Click(object sender, EventArgs e){}
		private void label12_Click(object sender, EventArgs e){}
		private void UsuarioInterfaz_Load(object sender, EventArgs e){}

		private void btCrearReceta_Click(object sender, EventArgs e)
		{

		}

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }

        private void accesoURRh1_Load(object sender, EventArgs e)
        {

        }

        private void RellenarRecetas(List<Receta> rec)
        {
            Random rnd = new Random();
            int i = rec.Count;
            List<int> usados = new List<int>();

            foreach (Control con in tableLayoutPanel4.Controls)
            {
                if (con.GetType() == accesoURRh1.GetType())
                {
                    if (i <= usados.Count)
                        break;

                    int z = 0;
                    do
                    {
                        z = rnd.Next(0, i);
                    } while (usados.Where(x => x == z).ToList().Count != 0);

                    usados.Add(z);

                    ((AccesoURRh)con).Foto = rec[z].Foto;
                    ((AccesoURRh)con).InfoTop = rec[z].IdReceta.ToString();
                    ((AccesoURRh)con).InfoMid = rec[z].Nombre;
                    ((AccesoURRh)con).InfoBot = u.Nombre;
                    ((AccesoURRh)con).ID = rec[z].IdReceta;
                    ((AccesoURRh)con).Tipo = "Receta";
                    ((AccesoURRh)con).CualquierClick += (object sender, EventArgs e) =>
                    {
                        parent.GoReceta(Receta.GetReceta(((AccesoURRh)con).ID));
                    };
                }
            }

        }
    }
}
