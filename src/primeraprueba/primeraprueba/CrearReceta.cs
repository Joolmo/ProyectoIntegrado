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
	public partial class CrearReceta : Form
    {
        Base parent = null;

        public CrearReceta(Base par)
		{
			InitializeComponent();

            MdiParent = par;
            parent = par;
            WindowState = FormWindowState.Maximized;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = new Bitmap(open.FileName);
            }
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            if(Usuario.UsuarioActual != null)
            {
                Receta receta = new Receta();
                receta.IdUsuario = Usuario.UsuarioActual.ID_Usuario;
                receta.Foto = picFoto.Image;
                receta.Indredientes = Buscador.ObtenerIngredientes(txtIngredientes.Text);
                receta.Pasos = txtPasos.Text;
                receta.Tags = tgsTags.Tag;
                receta.Nombre = txtNombreReceta.Text;

                ConexionBBDD.Instanciar().AbrirConexion();
                Receta.CrearReceta(receta);
                ConexionBBDD.Instanciar().CerrarConexion();
            }
        }

        private void Tags2_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnyadirTag_Click(object sender, EventArgs e)
        {
            tgsTags.AnyadirTag(txtTag.Text);
        }

        private void BtnEliminarTag_Click(object sender, EventArgs e)
        {
            tgsTags.EliminarTag();
        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrearReceta_Load(object sender, EventArgs e)
        {
            if(Usuario.UsuarioActual != null)
            {
                picFotoUsuario.Image = Usuario.UsuarioActual.Foto;
                lblUsuario.Text = Usuario.UsuarioActual.Nombre;
            }


        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ptbApp_Click(object sender, EventArgs e)
        {
            parent.GoHome();
        }
    }
}
