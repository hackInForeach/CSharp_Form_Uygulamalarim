using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToInt32(tbxVize.Text);
            double final = Convert.ToInt32(tbxFinal.Text);

            if (vize < 0 | vize > 100 && final < 0 | final > 100)
            {

                MessageBox.Show(" Negatif veya 100 den büyük bir sayı girme!!");

            }
            else
            {
                double hesapla = vize * 0.4 + final * 0.6;

                if (final < 35)
                {

                    MessageBox.Show("Kaldınız notunuz: " + hesapla + "\n" +
                        "Nedeni: Final gerekliliği olarak sınavdan 35'den düşük aldınız!");
                }

                else
                    MessageBox.Show("Geçtiniz Notunuz: " + hesapla);

                tbxFinal.Text = "";
                tbxVize.Text = "";

            }

        }
    }
}
