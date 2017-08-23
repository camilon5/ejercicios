using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pth, ptm, ch, cm, tp;

            ch = double.Parse(textBox1.Text);
            cm = double.Parse(textBox2.Text);

            tp = ch + cm;
            pth = (ch * 100) / tp;
            ptm = (cm * 100) / tp;

            MessageBox.Show("Porcentaje Hombres Es: " + pth + " Porcetaje Mujeres Es:   " + ptm);
        }

    }
}