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

		private void label2_Click(object sender, EventArgs e){}
		private void textBox5_TextChanged(object sender, EventArgs e){}
		private void textBox6_TextChanged(object sender, EventArgs e){}
		private void pictureBox2_Click(object sender, EventArgs e){}
		private void Registrarse_Load(object sender, EventArgs e){}

		private void button1_Click(object sender, EventArgs e)
		{
            errorProvider1.Clear();
            if (Validar())
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

        private bool Validar()
        {
            bool val = true;
            if(txtNombre.Text == "")
            {
                val = false; ;
                errorProvider1.SetError(txtNombre, "INTRODUCE UN NOMBRE PARA EL USUARIO");
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

            if(txtCorreo.Text == "")
            {
                val = false;
                errorProvider1.SetError(txtCorreo, "PON UN CORREO");
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
    }
}
