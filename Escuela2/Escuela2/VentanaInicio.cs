﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela2
{
    public partial class VentanaInicio : Form
    {
        VentanaMateria ventana1 = new VentanaMateria();
        public VentanaInicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxusuario.Text.Equals("Usuario") && txbcontraseña.Text == ("1234"))
            {
                MessageBox.Show("Sea Bienvenido ");
                ventana1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrecta, por favor intente de nuevo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}