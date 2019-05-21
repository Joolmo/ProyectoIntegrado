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

		public Recetas(Base par, Receta receta)
		{
			InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;

            ptbFoto.Image = Usuario.GetUsuario(receta.IdUsuario).Foto;
            ptbReceta.Image = receta.Foto;
            foreach(String tag in receta.Tags) tags1.AnyadirTag(tag);
            foreach (string ing in receta.Indredientes) tbpIngredientes.Text += ing + "/n";
            tbpPasos.Text = receta.Pasos;
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

        }
    }
}
