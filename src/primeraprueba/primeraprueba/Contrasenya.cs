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
    }
}
