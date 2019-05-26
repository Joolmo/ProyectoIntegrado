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
	public partial class login : Form
	{

        Base parent = null;
		public login(Base par)
		{
			InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
        }

		private void label3_Click(object sender, EventArgs e){}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

		private void btIniciar_Click(object sender, EventArgs e)
		{
			if(Usuario.LogIn(txtNombre.Text, txtContra.Text))
            {
                parent.GoHome();
            }
            else
            {
                var error = ConexionBBDD.Instanciar().LastError;
                if (error == "Sin errrores")
                {
                    MessageBox.Show("Has puesto mal el usuario o la cntraseña");
                }
                else
                {
                    MessageBox.Show(error);
                }
                
            }
		}

		private void btRegistrar_Click(object sender, EventArgs e)
		{
            parent.GoRegistro();
		}



		private void linlContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		
			
			
		}

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }

        private void login_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblInicio.Text = StringRecursos.inicioLogin;
            lblNombre.Text = StringRecursos.nombreLogin;
            lblContraseña.Text = StringRecursos.contrasenyaLogin;
            btIniciar.Text = StringRecursos.iniciarLogin;
            btRegistrar.Text = StringRecursos.registrarLogin;
            linkContraseña.Text = StringRecursos.contrasenyaOlvidadaLogin;
        }
    }
}
