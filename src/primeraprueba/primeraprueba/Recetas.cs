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
	public partial class Recetas : Form
	{
        Base parent = null;

        Receta r;
		public Recetas(Base par, Receta receta)
		{
			InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
            r = receta;

            Usuario usuario = Usuario.GetUsuario(receta.IdUsuario);
            lblRetoRecetas.Text = receta.Nombre;
            ptbFoto.Image = usuario.Foto;
            ptbReceta.Image = receta.Foto;
            lblnomusu.Text = usuario.Nombre;
            foreach(string tag in receta.Tags) tags1.AnyadirTag(tag);
            foreach (string ing in receta.Indredientes) lblIngredientes.Text += ing + "\n";
            lblPasos.Text = receta.Pasos;
        }

		private void pictureBox2_Click(object sender, EventArgs e){}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

        private void btENVIAR_Click(object sender, EventArgs e)
        {

        }

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }

        private void PtbReceta_Click(object sender, EventArgs e)
        {

        }

        private void Recetas_Load(object sender, EventArgs e)
        {

        }

        private void tbpIngredientes_Click(object sender, EventArgs e)
        {

        }

        private void lblnomusu_Click(object sender, EventArgs e)
        {
            parent.GoUsuario(Usuario.GetUsuario(r.IdUsuario));
        }
    }
}
