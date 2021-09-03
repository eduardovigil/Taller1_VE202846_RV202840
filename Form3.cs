using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1_VE202846_RV202840
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                int a;
                a = Convert.ToInt32(textBox1.Text);
                if (a >= 1 && a <= 4)
                {
                    //agregamos valores al lbs
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Ingresaste numeros invalidos intentalo de nuevo");
                    textBox1.Clear();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidadnumeros1 = listBox1.Items.Count;
            double voto = 0;
            double delo;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 1)
                {
                    voto = voto + 1;
                }
                else
                {
                    //Si no hubiera votos del candidato
                    textBox2.Text = "Nadie voto por el candidato 1";
                }
            }
            delo = (voto / cantidadnumeros1) * 100;
            textBox2.Text = delo.ToString() + "%";
            //declaramos variables
            double cantidadnumeros = listBox1.Items.Count;
            double cantidad = 0;
            double porcentaje = 0;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 2)
                {
                    cantidad = cantidad + 1;
                }
                else
                {
                    //Si no hubiera votos del candidato
                    textBox3.Text = "Nadie voto por el candidato 2";
                }
            }
            porcentaje = (cantidad / cantidadnumeros) * 100;
            textBox3.Text = porcentaje.ToString() + "%";

            //declaramos variables
            double cantidadnumeros3 = listBox1.Items.Count;
            double cantidad2 = 0;
            double porcentaje2 = 0;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 2)
                {
                    cantidad2 = cantidad2 + 1;
                }
                else
                {
                    //Si no hubiera votos del candidato
                    textBox4.Text = "Nadie voto por el candidato 3";
                }
            }
            porcentaje2 = (cantidad2 / cantidadnumeros3) * 100;
            textBox4.Text = porcentaje2.ToString() + "%";

            //declaramos variables
            double cantidadnumero = listBox1.Items.Count;
            double cantidades = 0;
            double porcentajes = 0;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 4)
                {
                    cantidades = cantidad + 1;
                }
                else
                {
                    //Si no hubiera votos del candidato
                    textBox5.Text = "Nadie voto por el candidato 4";
                }
            }
            porcentajes = (cantidades / cantidadnumero) * 100;
            textBox5.Text = porcentajes.ToString() + "%";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario4 = new menu();
            formulario4.Show();
            this.Hide();
        }
    }
}
