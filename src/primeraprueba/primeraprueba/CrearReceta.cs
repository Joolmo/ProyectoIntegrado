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
                picFoto.Image = new Bitmap(open.FileName);
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            if(Usuario.UsuarioActual != null)
            {
                Receta receta = new Receta()
                {
                    IdUsuario = Usuario.UsuarioActual.ID_Usuario,
                    Foto = picFoto.Image,
                    Indredientes = Buscador.ObtenerIngredientes(txtIngredientes.Text),
                    Pasos = txtPasos.Text,
                    Tags = tgsTags.Tag,
                    Nombre = txtNombreReceta.Text,
                };

                ConexionBBDD.Instanciar().AbrirConexion();
                bool valido = Receta.CrearReceta(receta);  
                ConexionBBDD.Instanciar().CerrarConexion();

                if (valido)
                    parent.GoHome();
                else
                    MessageBox.Show(ConexionBBDD.Instanciar().LastError);
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

            AplicarIdioma();
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

        private void AplicarIdioma()
        {
            lblNombreReceta.Text = StringRecursos.nomRecetaRec;
            lblInsertarImagen.Text = StringRecursos.insertarImagenRec;
            lblIngredientes.Text = StringRecursos.ingredientesRec;
            lblPasos.Text = StringRecursos.pasosRec;
            btnAnyadirTag.Text = StringRecursos.btnAddTagRec;
            btnEliminarTag.Text = StringRecursos.btnBorrarTagRec;
            btCancelar.Text = StringRecursos.btnCancelRec;
            btEnviar.Text = StringRecursos.btnEnviarRec;

        }
    }
}
