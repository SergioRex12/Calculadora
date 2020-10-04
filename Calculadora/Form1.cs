using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {
        }

        private void valor2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Llego");

            string num1 = valor1.Text.Trim();
            string num2 = valor2.Text.Trim();
            int indice = operacion.SelectedIndex;
            string operacionrex = operacion.Items[indice].ToString();

            Program program = new Program();
            program.Inicio(num1, num2, operacionrex);
        }

        private void tipoop_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
