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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e){}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

		private void btIniciar_Click(object sender, EventArgs e)
		{
			Hide();
			Home homeusuario = new Home();
			homeusuario.ShowDialog();
			
		}

		private void btRegistrar_Click(object sender, EventArgs e)
		{
			Hide();
			Registrarse Registro = new Registrarse();
			Registro.ShowDialog();
		}



		private void linlContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			Contrasenya reg = new Contrasenya();
			reg.ShowDialog();
			
			
		}
	}
}
