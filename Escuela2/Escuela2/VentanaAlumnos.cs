using System;
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
    public partial class Alumnos : Form
    {
        Alumno alumno = new Alumno();
        public Alumnos()
        {
            InitializeComponent();
        }

        private void VentanaAlumnos_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese unicamente numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                alumno.entid = entidad.Items.ToString();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void ingresar_Click_1(object sender, EventArgs e)
        {
            ingresar();
            MessageBox.Show("El alumno fue registrado");
            Datos.Text = alumno.ToString();
            limpiar();
        }

        private void matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaMateria Mater = new VentanaMateria();
            Mater.Show();
            this.Dispose();
        }
    }
}