using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tl, tm, tv, promedio;
            tl = float.Parse(textBox1.Text);
            tm = float.Parse(textBox2.Text);
            tv = float.Parse(textBox3.Text);

            promedio = (tl + tm + tv) / 3;
            MessageBox.Show("su tiempo es de" + promedio);





        }
    }
}
