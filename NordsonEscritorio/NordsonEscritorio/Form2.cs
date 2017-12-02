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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Loggear_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            try
            {
                if (cliente.LoggearCliente(int.Parse(txtNumEmpleado.Text), txtContrasena.Text))
                {
                    MessageBox.Show("Bienvenido");
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                    this.Close();
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
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
