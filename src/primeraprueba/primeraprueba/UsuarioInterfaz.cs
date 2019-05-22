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
	public partial class UsuarioInterfaz : Form
	{

        Base parent = null;
        public UsuarioInterfaz(Base par, Usuario usu)
		{
			InitializeComponent();

            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;

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
    }
}
