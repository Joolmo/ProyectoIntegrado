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
		public Registrarse()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e){}
		private void textBox5_TextChanged(object sender, EventArgs e){}
		private void textBox6_TextChanged(object sender, EventArgs e){}
		private void pictureBox2_Click(object sender, EventArgs e){}
		private void Registrarse_Load(object sender, EventArgs e){}

		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			Home registra = new Home();
			registra.ShowDialog();

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			login inicio = new login();
			inicio.ShowDialog();
		}
	}
}
