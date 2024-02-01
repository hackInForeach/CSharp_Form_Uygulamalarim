using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAlisVerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblTutar.Text = "Tutar: ";

            double hesap = 0;
            double indirim = 0.25;

            lstSiparisListesi.Items.Clear();

            if (chxCay.Checked)
            {
                hesap += 5;
                lstSiparisListesi.Items.Add(chxCay.Text);
            }
            if (chxTost.Checked)
            {
                hesap += 10;
                lstSiparisListesi.Items.Add(chxTost.Text);
            }
            if (chxHamburger.Checked)
            {
                hesap += 25;
                lstSiparisListesi.Items.Add(chxHamburger.Text);
            }
            if (chxSanvich.Checked)
            {
                hesap += 35;
                lstSiparisListesi.Items.Add(chxSanvich.Text);
            }
            if (chxPiskevit.Checked)
            {
                hesap += 15;
                lstSiparisListesi.Items.Add(chxPiskevit.Text);
            }

            if (hesap >= 80)
            {
                indirim = 0.75;
                hesap -= hesap * indirim;
                MessageBox.Show("Tebrikler 80₺ ver üzeri alış verişlermizde\n %75 indirim kazandınız!");
                lstSiparisListesi.Items.Add(lblTutar.Text + hesap);
            }

            else if (hesap >= 50)
            {
                hesap -= hesap * indirim;
                MessageBox.Show("Tebrikler 50₺ ver üzeri alış verişlermizde\n %25 indirim kazandınız!");
                lstSiparisListesi.Items.Add(lblTutar.Text + hesap);
            }
            else
                lstSiparisListesi.Items.Add(lblTutar.Text + hesap);

            lblTutar.Text = "Tutar: " + hesap;
            chxCay.Checked = false;
            chxHamburger.Checked = false;
            chxPiskevit.Checked = false;
            chxSanvich.Checked = false;
            chxTost.Checked = false;

        }
    }
}
