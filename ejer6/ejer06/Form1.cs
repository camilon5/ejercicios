using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double an, aac, edad;

            aac = double.Parse(textBox1.Text);
            an = double.Parse(textBox2.Text);

            edad = aac - an;

            MessageBox.Show("Su Edad Es:   "    + edad);
        }
    }
}
