using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordsonEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            try
            {
                if (client.RegistrarCliente(txtNombre.Text, txtContrasena.Text, txtCargo.Text, int.Parse(txtTurno.Text), int.Parse(txtNoEmpleado.Text)))
                {
                    MessageBox.Show("Registro realizado exitosamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups, algo salió mal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
    }

