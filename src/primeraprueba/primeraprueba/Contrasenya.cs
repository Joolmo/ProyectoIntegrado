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
		public Contrasenya()
		{
			InitializeComponent();
		}

		private void btIniciar_Click(object sender, EventArgs e)
		{
			Hide();
			login logear = new login();
			logear.ShowDialog();
		}


	}
}
