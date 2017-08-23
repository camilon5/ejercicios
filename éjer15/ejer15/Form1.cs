using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, pc1, pc2, pc3,montot;

            c1 = double.Parse(textBox1.Text);
            c2 = double.Parse(textBox2.Text);
            c3 = double.Parse(textBox3.Text);

            montot = c1 + c2 + c3;

            pc1 = (c1 * 100) / montot;
            pc2 = (c2 * 100) / montot;
            pc3 = (c3 * 100) / montot;

            MessageBox.Show("El Porcentaje Cliente 1 Es:   " + pc1   +   "El Porcentaje Cliente 2 Es:  "  +  pc2  +  "El Porcentaje Cliente 3 Es:  "  +pc3);
        }
    }
}
