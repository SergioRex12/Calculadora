using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Form1());
        }

        public void Inicio(string num1, string num2, string operacionrex)
        {
            //Console.WriteLine(num1 + " " + num2 + " " + operador);

            //si quieres saber si es un numero lo puedes hacer;
            bool esNumero = int.TryParse(num1,out int numero1);
            bool esNumero2 = int.TryParse(num2,out int numero2);
            if (esNumero && esNumero2)
            {

                switch (operacionrex)
                {
                    case "Sumar":
                        int resultado = numero1 + numero2;
                        Console.WriteLine(resultado);
                        MessageBox.Show("Resultado de la suma: " + resultado,"Resultado suma");
                        break;
                    default:
                    break;
                }

            } else
            {
                Console.WriteLine("Un numero es incorrecto...");
            }
            /*int numero1 = Convert.ToInt32(num1);
            int numero2 = Convert.ToInt32(num2);

            int test = numero1 + numero2;
            Console.WriteLine(test);*/

        }
            
    }
}
