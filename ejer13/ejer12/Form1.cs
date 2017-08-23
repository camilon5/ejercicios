using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double articulo, valor, ganacia;
            articulo = double.Parse(textBox1.Text);
            ganacia =  articulo*0.30;
            valor = articulo + ganacia;
            MessageBox.Show("el valor a vender" + valor);
            MessageBox.Show("la ganancia es" + ganacia);

            

        }
    }
}
