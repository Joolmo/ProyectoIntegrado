﻿using System;
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
    public partial class Base : Form
    {

        Form actual = null;
        
        public Base()
        {
            InitializeComponent();
            IsMdiContainer = true;
            MainMenuStrip = new MenuStrip();
        }

        

        private void Base_Load(object sender, EventArgs e)
        {
            actual = new Home(this);
            actual.Show();
        }

        public void GoHome()
        {
            actual.Dispose();
            actual = new Home(this);
            actual.Show();
        }

        //public void GoReceta(Receta rec)
        //{
        //    actual.Dispose();
        //    actual = new Recetas(this, rec);
        //    actual.Show();
        //}

        public void GoRegistro()
        {
            actual.Dispose();
            actual = new Registrarse(this);
            actual.Show();
        }

        public void GoLogin()
        {
            actual.Dispose();
            actual = new login(this);
            actual.Show();

        }


    }
}
