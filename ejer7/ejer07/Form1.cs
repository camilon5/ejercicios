using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dato_Click(object sender, EventArgs e)
        {
            double cantidad, dolar = 2964, dato;
            cantidad = double.Parse(textBox1.Text);
            dato = cantidad / dolar;
            MessageBox.Show("su dato final es de" + dato);

        }
    }
}
