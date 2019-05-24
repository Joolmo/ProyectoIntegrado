using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using primeraprueba.RecursosLocalizables;
using System.Globalization;
using System.Threading;

namespace primeraprueba
{
	public partial class Contrasenya : Form
	{
        Base parent = null;
        public Contrasenya(Base par)
		{
			InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
        }

		private void btIniciar_Click(object sender, EventArgs e)
		{
            parent.GoLogin();
		}

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }

        private void Contrasenya_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblContraseña.Text = StringRecursos.tituloCon;
            lblCorreo.Text = StringRecursos.correoCon;
            lblContraseñaN.Text = StringRecursos.contrasenyaCon;
            lblContraseña.Text = StringRecursos.contrasenyaConfirmarCon;
            btConfirmar.Text = StringRecursos.btnconfirmarCon;
            btIniciar.Text = StringRecursos.btnIniciarCon;
        }
    }
}
