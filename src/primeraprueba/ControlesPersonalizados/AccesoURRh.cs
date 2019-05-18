using System.Windows.Forms;
using System.Drawing;

namespace ControlesPersonalizados
{
    public partial class AccesoURRh : UserControl
    {
        #region propieades
        public string InfoTop
        {
            get { return lblInfoTop.Text; }
            set { lblInfoTop.Text = value; }
        }

        public string InfoMid
        {
            get { return lblInfoMid.Text; }
            set { lblInfoMid.Text = value; }
        }

        public string InfoBot
        {
            get { return lblInfoBot.Text; }
            set { lblInfoBot.Text = value; }
        }

        public Image Foto
        {
            get { return picFoto.Image; }
            set { picFoto.Image = value; }
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

        public AccesoURRh()
        {
            InitializeComponent();
        }
    }
}
