using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CAFE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, resultado;
            a = float.Parse(txtPrecio.Text);
            b = int.Parse(numCantidad.Text);
            resultado = a * b;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = txtCliente.Text;
            fila.Cells[1].Value = txtDNI.Text;
            fila.Cells[2].Value = cmbProducto.Text;
            fila.Cells[3].Value = numCantidad.Text;
            fila.Cells[4].Value = txtPrecio.Text;
            fila.Cells[5].Value = resultado.ToString();
            fila.Cells[6].Value = cmbTipoPago.Text;
            fila.Cells[7].Value = cmbUsuario.Text;
            fila.Cells[8].Value = dtFecha.Text;

            dataGridView1.Rows.Add(fila);
            txtCliente.Text = "";
            txtDNI.Text = "";
            cmbProducto.Text = "";
            numCantidad.Text = "";
            txtPrecio.Text = "";
            cmbTipoPago.Text = "";
            cmbUsuario.Text = "";
            dtFecha.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
