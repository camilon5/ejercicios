using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double porct = 0.55, porcex = 0.30, porctra = 0.15,n1,n2,n3,n4,n5,vnt,vne,vntr,nf;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);
            n5 = double.Parse(textBox5.Text);

            vnt = ((n1 + n2 + n3)/3) * porct;
            vne = n4 * porcex;
            vntr = n5 * porctra;
            nf = vnt + vne + vntr;

            MessageBox.Show("Su Nota Final Es: " + nf);

        }
    }
}
