using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxEkle.Enabled = false;
            btnEkle.Enabled = false;
            btnOrt.Enabled = false;
        }
        int[] dizi;

        private void btnBoyut_Click(object sender, EventArgs e)
        {
            int diziNumber = Convert.ToInt32(tbxBoyut.Text);
            dizi = new int[diziNumber];
            lblBoyut.Text = Convert.ToString(tbxBoyut.Text);
            tbxBoyut.Text = "";
            tbxBoyut.Enabled = false;
            tbxEkle.Enabled = true;
            btnEkle.Enabled = true;

        }
        int i = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (i < dizi.Length - 1)
            {
                dizi[i] = Convert.ToInt32(tbxEkle.Text);
                lblEkle.Text = Convert.ToString(tbxEkle.Text);
                tbxEkle.Text = "";
                lblKalan.Text = Convert.ToString(dizi.Length - i - 1);
                i++;
            }
            else
            {
                dizi[i] = Convert.ToInt32(tbxEkle.Text);
                lblKalan.Text = Convert.ToString(dizi.Length - i - 1);
                tbxEkle.Text = "";
                tbxEkle.Enabled = false;
                btnEkle.Enabled = false;
                btnBoyut.Enabled = false;
                btnOrt.Enabled = true;
            }
        }
        double toplam = 0;
        private void btnOrt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            double sonuc = toplam / dizi.Length;
            lblOrt.Text = Convert.ToString(Convert.ToDouble(sonuc));
            btnOrt.Enabled = false;
        }
    }
}
