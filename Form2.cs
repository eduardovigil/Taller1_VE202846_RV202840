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
    public partial class Form2 : Form
    {

 
        public Form2()
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
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                double a;     
                a = Convert.ToDouble(txtnumero.Text);
                if(a >= 1)
                {
                //agregamos valores al lbs
                lsbArreglo.Items.Add(txtnumero.Text);
                txtnumero.Clear();
                txtnumero.Focus();

            }
            else
            {
                MessageBox.Show("Ingresaste numeros invalidos intentalo de nuevo");
                txtnumero.Clear();
            }



            int contador = 0;



            if (lsbArreglo.Items.Count == 4)
                {
                    txtnumero.Enabled = false;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
                for (int i = 0; i < lsbArreglo.Items.Count; i++)
                {
                    string valor = lsbArreglo.Items[i].ToString();
                    int numeros = int.Parse(valor);
                    contador = contador + numeros;
                }
                

                if (contador >= 200)
                {
                    MessageBox.Show("Cantidad de numeros excedidos vuelva a intentarlo");
                lsbArreglo.Items.Clear();
                txtnumero.Clear();
                contador = 0;
                textBox1.Clear();
                textBox2.Clear();
                }

                
            int valormaximo = 0;
            int val;
            for(int i = 0; i< lsbArreglo.Items.Count; i++)
            {    
                    val = int.Parse(lsbArreglo.Items[i].ToString());
                    if (val >= valormaximo)
                    {
                        valormaximo = val;
                    }
                    
                

            }

            int valormin = 200;
            int valmin;
            for (int i = 0; i < lsbArreglo.Items.Count; i++)
            {
                valmin = int.Parse(lsbArreglo.Items[i].ToString());
                
                if (valmin <= valormin)
                {
                    valormin = valmin;
                }
                textBox1.Text = Convert.ToString(valormin);
            }
            if(lsbArreglo.Items.Count == 4)
                { 
            if (valormin > 10)
            {
                valormaximo += 10;
                textBox2.Text = Convert.ToString(valormaximo);
                MessageBox.Show("Tu numero mayor incremento 10 unidades");
            }
            else
            {
                textBox2.Text = Convert.ToString(valormaximo);
            }

                if (valormaximo < 50)
                {
                    valormin -= 5;
                    textBox1.Text = Convert.ToString(valormin);
                    MessageBox.Show("Tu numero menor se le restaron 5 unidades");
                }
                else
                {
                    textBox1.Text = Convert.ToString(valormin);
                }
            }

            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario4 = new menu();
            formulario4.Show();
            this.Hide();
        }
    }
    }

