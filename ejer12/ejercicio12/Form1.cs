using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ginecologia, Pediatria, Traumatologia, mr, pag = 0.40, pap = 0.30, pat = 0.30;

            mr = double.Parse(textBox1.Text);

            Ginecologia = (mr * pag) ;
            Pediatria = (mr * pap) ;
            Traumatologia = (mr * pat) ;

            MessageBox.Show("El Valor Area Ginecologia es:  " + Ginecologia      +     "El Valor Area Pediatria Es:  " + Pediatria      +    "El Valor Area Traumatologia Es:   "     +   Traumatologia);
         

        }
    }
}
