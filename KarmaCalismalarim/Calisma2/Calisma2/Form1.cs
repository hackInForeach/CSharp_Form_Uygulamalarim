using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int faktoriel(int sayi)
        {
            int fk = 1;
            for (int i = sayi; i > 0; i--)
            {
                fk *= i;
            }
            return fk;

        }

        private void tbxSayi2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxSayi2.Text) & String.IsNullOrEmpty(tbxSayi2.Text) | String.IsNullOrWhiteSpace(tbxSayi1.Text) & String.IsNullOrEmpty(tbxSayi1.Text))
            {
                lblCikti.Text = "Lütfen İki Alanıda Boş Bırakmayınız!";
            }
            else
            {
                if (Convert.ToInt32(tbxSayi2.Text)>10 | Convert.ToInt32(tbxSayi1.Text)>10)
                {
                    lblCikti.Text = "Lüften 10'dan küçük bir sayı gir.";
                }
                else
                {
                    int s = faktoriel(Convert.ToInt32(tbxSayi2.Text)) + faktoriel(Convert.ToInt32(tbxSayi1.Text));
                    lblCikti.Text = Convert.ToString(s);
                }
                
            }


        }
    }
}
