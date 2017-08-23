using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           float n, absoluto;
           n = float.Parse(textBox1.Text);
           absoluto = Math.Abs(n);
           MessageBox.Show("su valor absoluto es" + absoluto);


        }
    }
}
