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
	public partial class Registrarse : Form
	{
        Base parent = null;
		public Registrarse(Base par)
		{
			InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
        }

        public Registrarse(Base par, bool i)
        {
            InitializeComponent();
            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
            ptbImagen.Image = Usuario.UsuarioActual.Foto;
            txtNombre.Text = Usuario.UsuarioActual.Descripcion;
            lblDesc.Visible = true;
            btRegistrar.Visible = false;
            btnModificar.Visible = true;
            lblNombre.Visible = false; ;
            txtNombre.Height = 15;
            lblCorreo.Visible = false;
            txtCorreo.Visible = false;
            linkIniciar.Visible = false;


        }

        private void label2_Click(object sender, EventArgs e){}
		private void textBox5_TextChanged(object sender, EventArgs e){}
		private void textBox6_TextChanged(object sender, EventArgs e){}
		private void pictureBox2_Click(object sender, EventArgs e){}
		private void Registrarse_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            errorProvider1.Clear();
            if (Validar(1))
            {

                Usuario reg = new Usuario(txtNombre.Text, txtContra.Text, txtCorreo.Text, "", ptbImagen.Image);
                Usuario.RegistrarUsuario(reg);

                parent.GoHome();
            }
            

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            parent.GoLogin();
		}

        private bool Validar(int i)
        {
            bool val = true;
            if(txtNombre.Text == "")
            {
                val = false; ;
                errorProvider1.SetError(txtNombre, "INTRODUCE ALGO");
            }

            if(txtContra.Text == "")
            {
                val = false;
                errorProvider1.SetError(txtContra, "PON UNA CONTRASEÑA");
            }
            else
            {
                if(txtConfirContra.Text != txtContra.Text)
                {
                    val = false;
                    errorProvider1.SetError(txtConfirContra, "PON LA MISMA CONTRASEÑA");
                }
            }
            if(i == 1)
            {
                if (txtCorreo.Text == "")
                {
                    val = false;
                    errorProvider1.SetError(txtCorreo, "PON UN CORREO");
                }
            }
            


            return val;
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = new Bitmap(open.FileName);
            }
        }

        private void AplicarIdioma()
        {
            lblNombre.Text = StringRecursos.nombreLogin;
            lblCorreo.Text = StringRecursos.correoCon;
            lblContra.Text = StringRecursos.contrasenyaLogin;
            lblConfirContra.Text = StringRecursos.contrasenyaConfirmarCon;
            linkIniciar.Text = StringRecursos.iniciarLogin;
            btRegistrar.Text = StringRecursos.registrarLogin;
            btnModificar.Text = StringRecursos.btnModificar;
            lblDesc.Text = StringRecursos.lblDesc;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtContra.Text == "") i = 0;
            else i = 1;
            errorProvider1.Clear();
            if(txtContra.Text == txtConfirContra.Text)
            {
                Usuario.ModificarUsuario(i, Usuario.UsuarioActual.ID_Usuario, txtNombre.Text, txtContra.Text, ptbImagen.Image);
                Usuario.ActualizarUsuario();
                parent.GoUsuario(Usuario.UsuarioActual);
            }
            else
            {
                errorProvider1.SetError(txtConfirContra, "PON LA MISMA CONTRASEÑA");
            }
                
            
            
            
        }

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }
    }
}
