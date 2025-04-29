using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        Alumno alumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese unicamente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("Ingrese unicamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese unicamente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            ingresar();
            MessageBox.Show("El alumno fue registrado");
            Datos.Text = alumno.ToString();
            limpiar();
        }

        public void ingresar()
        {
            alumno.nom = Datos.Text;
            alumno.eda = int.Parse(edad1.Value.ToString());
            alumno.telf = int.Parse(telefono.Text);

            if (femen.Checked == true)
            {
                alumno.sex = 'f';
            }
            if (masc.Checked == true)
            {
                alumno.entid = entidad.Items.ToString();
            }
        }

        public void limpiar()
        {
            nombre.Text = null;
            telefono.Text = null;
            edad1.Value = 17;
            femen.Checked = false;
            masc.Checked = false;
            entidad.SelectedIndex = 0;
        }
    }
}