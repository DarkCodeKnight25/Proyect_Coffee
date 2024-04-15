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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = "";
            string contraseña = "";
            if (!txtUsername.Equals("") && !txtPassword.Equals(""))
            {
                usuario = txtUsername.Text;
                contraseña = txtPassword.Text;
            }
            if (usuario.Equals("user001") && contraseña == "72977717" && chkTerminos.Checked)
            {
                Form2 LOGISTICA = new Form2();
                this.Hide();
                LOGISTICA.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
