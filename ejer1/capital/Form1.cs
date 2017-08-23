using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double capital, i = 0.02, ganancia;
            capital = double.Parse(textBox1.Text);
            ganancia = capital * 0.02;

            MessageBox.Show("Su Gananncia Es De: " + ganancia);


        }
    }
}
