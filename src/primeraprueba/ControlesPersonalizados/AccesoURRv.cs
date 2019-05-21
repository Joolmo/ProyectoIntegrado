using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public partial class AccesoURRv: UserControl
    {

        #region
        public Image Foto
        {
            get { return picFoto.Image; }
            set { picFoto.Image = value; }
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        public AccesoURRv()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
