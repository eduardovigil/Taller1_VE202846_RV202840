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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox2.Text);
            if (a >= 1)
            {
                txtName1.Enabled = false;
                txtApellido1.Enabled = false;
                cmbCargo1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                txtName2.Enabled = true;
                txtApellido2.Enabled = true;
                cmbCargo2.Enabled = true;
                textBox4.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingresaste numeros invalidos intentalo de nuevo");
            }

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            cmbCargo1.Items.Add("Gerente");
            cmbCargo1.Items.Add("Asistente");
            cmbCargo1.Items.Add("Secretaria");
            cmbCargo1.Items.Add("Otros");
            cmbCargo2.Items.Add("Gerente");
            cmbCargo2.Items.Add("Asistente");
            cmbCargo2.Items.Add("Secretaria");
            cmbCargo2.Items.Add("Otros");
            cmbCargo3.Items.Add("Gerente");
            cmbCargo3.Items.Add("Asistente");
            cmbCargo3.Items.Add("Secretaria");
            cmbCargo3.Items.Add("Otros");


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            if (a >= 1)
            {
                txtName2.Enabled = false;
                txtApellido2.Enabled = false;
                cmbCargo2.Enabled = false;
                textBox4.Enabled = false;
                button2.Enabled = false;
                txtName3.Enabled = true;
                txtApellido3.Enabled = true;
                cmbCargo3.Enabled = true;
                textBox7.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingresaste numeros invalidos intentalo de nuevo");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            txtName3.Enabled = false;
            txtApellido3.Enabled = false;
            cmbCargo3.Enabled = false;
            textBox7.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblempleado1.Text = Convert.ToString(txtApellido1.Text + " " + txtName1.Text);

            int hora1, restahora;
            double pago1, sup, mulres, total;
            hora1 = Convert.ToInt32(textBox2.Text);
            if (hora1 <= 160)
            {
                pago1 = hora1 * 9.75;
                textBox1.Text = Convert.ToString(pago1);
            }
            else if (hora1 >= 160)
            {
                restahora = hora1 - 160;
                sup = 160 * 9.75;
                mulres = restahora * 11.50;
                total = sup + mulres;
                textBox1.Text = Convert.ToString(total);
            }


            double isss, renta, afp, restatotal;
            double tx1;
            tx1 = Convert.ToDouble(textBox1.Text);
            isss = tx1 * 0.0527;
            renta = tx1 * 0.1;
            afp = tx1 * 0.0688;
            restatotal = tx1 - isss - renta - afp;
            textBox3.Text = Convert.ToString(isss);
            textBox5.Text = Convert.ToString(afp);
            textBox6.Text = Convert.ToString(renta);
            textBox8.Text = Convert.ToString(restatotal);

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            label29.Text = Convert.ToString(txtApellido2.Text + " " + txtName2.Text);

            int hora2, restahora2;
            double pago2, sup2, mulres2, total2;
            hora2 = Convert.ToInt32(textBox4.Text);
            if (hora2 <= 160)
            {
                pago2 = hora2 * 9.75;
                textBox13.Text = Convert.ToString(pago2);
            }
            else if (hora2 >= 160)
            {
                restahora2 = hora2 - 160;
                sup2 = 160 * 9.75;
                mulres2 = restahora2 * 11.50;
                total2 = sup2 + mulres2;
                textBox13.Text = Convert.ToString(total2);
            }


            double isss2, renta2, afp2, restatotal2;
            double tx2;
            tx2 = Convert.ToDouble(textBox13.Text);
            isss2 = tx2 * 0.0527;
            renta2 = tx2 * 0.1;
            afp2 = tx2 * 0.0688;
            restatotal2 = tx2 - isss2 - renta2 - afp2;
            textBox12.Text = Convert.ToString(isss2);
            textBox11.Text = Convert.ToString(afp2);
            textBox10.Text = Convert.ToString(renta2);
            textBox9.Text = Convert.ToString(restatotal2);

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            label36.Text = Convert.ToString(txtApellido3.Text + " " + txtName3.Text);

            int hora3, restahora3;
            double pago3, sup3, mulres3, total3;
            hora3 = Convert.ToInt32(textBox7.Text);
            if (hora3 <= 160)
            {
                pago3 = hora3 * 9.75;
                textBox18.Text = Convert.ToString(pago3);
            }
            else if (hora3 >= 160)
            {
                restahora3 = hora3 - 160;
                sup3 = 160 * 9.75;
                mulres3 = restahora3 * 11.50;
                total3 = sup3 + mulres3;
                textBox18.Text = Convert.ToString(total3);
            }


            double isss3, renta3, afp3, restatotal3;
            double tx3;
            tx3 = Convert.ToDouble(textBox18.Text);
            isss3 = tx3 * 0.0527;
            renta3 = tx3 * 0.1;
            afp3 = tx3 * 0.0688;
            restatotal3 = tx3 - isss3 - renta3 - afp3;
            textBox17.Text = Convert.ToString(isss3);
            textBox16.Text = Convert.ToString(afp3);
            textBox15.Text = Convert.ToString(renta3);
            textBox14.Text = Convert.ToString(restatotal3);


            string carg1, carg2, carg3;
            carg1 = Convert.ToString(cmbCargo1.Text);
            carg2 = Convert.ToString(cmbCargo2.Text);
            carg3 = Convert.ToString(cmbCargo3.Text);

            if (carg1 == "Gerente" && carg2 == "Asistente" && carg3 == "Secretaria")
            {
                textBox19.Text = "No hay bono";
                textBox20.Text = "No hay bono";
                textBox21.Text = "No hay bono";
            }

            if (carg1 == "Gerente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox8.Text);
                bonus1 = sl * 0.10;
                textBox19.Text = Convert.ToString(bonus1);
            }

            else if (carg1 == "Asistente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox8.Text);
                bonus1 = sl * 0.05;
                textBox19.Text = Convert.ToString(bonus1);
            }

            else if (carg1 == "Secretaria")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox8.Text);
                bonus1 = sl * 0.03;
                textBox19.Text = Convert.ToString(bonus1);
            }

            else if ( carg1 == "Otros")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox8.Text);
                bonus1 = sl * 0.02;
                textBox19.Text = Convert.ToString(bonus1);
            }

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            if (carg2 == "Gerente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox9.Text);
                bonus1 = sl * 0.10;
                textBox20.Text = Convert.ToString(bonus1);
            }

            else if (carg2 == "Asistente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox9.Text);
                bonus1 = sl * 0.05;
                textBox20.Text = Convert.ToString(bonus1);
            }

            else if (carg2 == "Secretaria")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox9.Text);
                bonus1 = sl * 0.03;
                textBox20.Text = Convert.ToString(bonus1);
            }

            else if (carg2 == "Otros")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox9.Text);
                bonus1 = sl * 0.02;
                textBox20.Text = Convert.ToString(bonus1);
            }

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            if (carg3 == "Gerente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox14.Text);
                bonus1 = sl * 0.10;
                textBox21.Text = Convert.ToString(bonus1);
            }

            else if (carg3 == "Asistente")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox14.Text);
                bonus1 = sl * 0.05;
                textBox21.Text = Convert.ToString(bonus1);
            }

            else if (carg3 == "Secretaria")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox14.Text);
                bonus1 = sl * 0.03;
                textBox21.Text = Convert.ToString(bonus1);
            }

            else if (carg3 == "Otros")
            {
                double bonus1, sl;
                sl = Convert.ToDouble(textBox14.Text);
                bonus1 = sl * 0.02;
                textBox21.Text = Convert.ToString(bonus1);
            }

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            double emple1, emple2, emple3;
            emple1 = Convert.ToDouble(textBox8.Text);
            emple2 = Convert.ToDouble(textBox9.Text);
            emple3 = Convert.ToDouble(textBox14.Text);

            if(emple1 > emple2 && emple1 > emple3)
            {
                textBox22.Text = "El empleado 1 es el que gana mayor salario";
            }

            else if (emple2 > emple1 && emple2 > emple3)
            {
                textBox22.Text = "El empleado 2 es el que gana mayor salario";
            }
            else if (emple3 > emple1 && emple3 > emple2)
            {
                textBox22.Text = "El empleado 3 es el que gana mayor salario";

            }

            //*************************************************************
            if (emple1 < emple2 && emple1 < emple3)
            {
                textBox23.Text = "El empleado 1 es el que gana menos";
            }

            else if (emple2 < emple1 && emple2 < emple3)
            {
                textBox23.Text = "El empleado 2 es el que gana menos";
            }
            else if (emple3 < emple1 && emple3 < emple2)
            {
                textBox23.Text = "El empleado 3 es el que gana menos";

            }

            int salconta = 0;

            if(emple1 > 300)
            {
                salconta += 1;
            }

             if( emple2 > 300)
            {
                salconta += 1;
            }
             if (emple3 > 300)
            {
                salconta += 1;
            }

            textBox24.Text = Convert.ToString(salconta);


            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario4 = new menu();
            formulario4.Show();
            this.Hide();
        }
    }
}
