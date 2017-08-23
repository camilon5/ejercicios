using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, incremento=0.25, nsalario;
            salario = double.Parse(textBox1.Text);
            incremento = salario * incremento;
            nsalario = salario + incremento;
            MessageBox.Show("su nuevo salario es" + nsalario);
        }
    }
}
