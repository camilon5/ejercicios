using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double edad,numpulsaciones;

           edad = double.Parse(textBox1.Text);
            			numpulsaciones = (220 - edad)/10;
            MessageBox.Show(""+numpulsaciones);

        }
    }
}
