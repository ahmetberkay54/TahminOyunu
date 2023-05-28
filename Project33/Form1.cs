using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
            int tah1, tah2, tah3, tah4, tah5, tah6;
            sayi1 = rnd.Next(1, 7);
            sayi2 = rnd.Next(1, 7);
            sayi3 = rnd.Next(1, 7);
            sayi4 = rnd.Next(1, 7);
            sayi5 = rnd.Next(1, 7);
            sayi6 = rnd.Next(1, 7);

            tah1 = Convert.ToInt16(textBox1.Text);
            tah2 = Convert.ToInt16(textBox2.Text);
            tah3 = Convert.ToInt16(textBox3.Text);
            tah4 = Convert.ToInt16(textBox4.Text);
            tah5 = Convert.ToInt16(textBox5.Text);
            tah6 = Convert.ToInt16(textBox6.Text);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();

            if (sayi1 == tah1 && sayi2 == tah2 && sayi3 == tah3 && sayi4 == tah4 && sayi5 == tah5 && sayi6 == tah6)
            {
                MessageBox.Show("TEBRIKLER IKRAMIYE KAZANDINIZ !!");
            }
            else
            {
                MessageBox.Show("MALESEF, TEKRAR DENEYINIZ");
            }
        }
    }
}
