using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descuentoejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vc, desc = 0.15, vdesc, t;

            vc = double.Parse(textBox1.Text);
            vdesc = vc * desc;
            t = vc - vdesc;
            MessageBox.Show("El Valor Total De Su Compra Es: " + t);
        }
    }
}
