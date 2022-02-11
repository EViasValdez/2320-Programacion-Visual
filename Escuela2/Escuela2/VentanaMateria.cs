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
    public partial class VentanaMateria : Form
    {
        Materia materia = new Materia();
        public VentanaMateria()
        {
            InitializeComponent();
        }
        public void enlazar_clase()
        {
            materia.id = int.Parse(txbxidmateria.Text);
            materia.mater = txbmateria.Text;
            materia.hora = int.Parse(cbhoras.SelectedItem.ToString());
            materia.cred = int.Parse(cbcreditos.SelectedItem.ToString());
        }
        private void btonsiguiente_Click_1(object sender, EventArgs e)
        {
            VentanaCalificaciones Calif = new VentanaCalificaciones();
            Calif.Show();
            this.Dispose();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txbxidmateria.Text.Equals("") && txbmateria.Text.Equals(""))
            {
                MessageBox.Show("Te hacen falta datos");
            }
            else
            {
                enlazar_clase();

                MessageBox.Show("Datos guardados en clase materias");

                txbxidmateria.Text = " ";
                txbmateria.Text = " ";
                cbhoras.Text = " ";
                cbcreditos.Text = " ";
            }
        }
        private void btondatos_Click_1(object sender, EventArgs e)
        {
            int numerofila = dgvinfo.Rows.Add();

            dgvinfo.Rows[numerofila].Cells[0].Value = materia.id;
            dgvinfo.Rows[numerofila].Cells[1].Value = materia.mater;
            dgvinfo.Rows[numerofila].Cells[2].Value = materia.hora;
            dgvinfo.Rows[numerofila].Cells[3].Value = materia.cred;
        }
    }
}