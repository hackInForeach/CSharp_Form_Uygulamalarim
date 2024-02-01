using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma4
{
    public partial class frmHeader1 : Form
    {
        public frmHeader1()
        {
            InitializeComponent();
        }
        public int toplam(int x, int y)
        {
            return x + y;
        }
        public int carpim(int x, int y)
        {
            return x * y;
        }

        private void tbxSayi2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSayi1.Text) | String.IsNullOrEmpty(tbxSayi1.Text) | String.IsNullOrEmpty(tbxSayi2.Text) | String.IsNullOrEmpty(tbxSayi2.Text))
            {
                lblCarpim1.Text = "İlgili alanları doldurun";
                lblToplam1.Text = "İlgili alanları doldurun";
            }
            else
            {
                int s1 = Convert.ToInt32(tbxSayi1.Text);
                int s2 = Convert.ToInt32(tbxSayi2.Text);
                lblToplam1.Text = Convert.ToString(toplam(s1, s2));
                lblCarpim1.Text = Convert.ToString(carpim(s1, s2));
            }
        }
    }
}
