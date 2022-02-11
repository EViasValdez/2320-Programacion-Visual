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
    public partial class VentanaCalificaciones : Form
    {
        Materia materia2 = new Materia();
        public VentanaCalificaciones()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Alumnos calif = new Alumnos();
            calif.Show();
            this.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void txbalumno_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int numerodelafila = dgvinfo2.Rows.Add();

            dgvinfo2.Rows[numerodelafila].Cells[0].Value = materia2.id;
            dgvinfo2.Rows[numerodelafila].Cells[1].Value = materia2.id;
            dgvinfo2.Rows[numerodelafila].Cells[2].Value = materia2.id;
        }
        private void Mostrar_Click(object sender, EventArgs e)
        {

        }
    }
}