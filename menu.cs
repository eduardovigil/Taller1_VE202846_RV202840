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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form4();
            formulario4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Form1();
            formulario1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form3();
            formulario2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form2();
            formulario3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
