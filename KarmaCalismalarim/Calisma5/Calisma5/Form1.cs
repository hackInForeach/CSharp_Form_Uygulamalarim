using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma5
{
    public partial class frmHeader : Form
    {
        public frmHeader()
        {
            InitializeComponent();
        }

        public int kare(int x, int y)
        {
            return x * x + y * y;
        }
        public int kup(int x, int y)
        {
            return x * x * x + y * y * y;
        }
        private void tbxSayi2_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbxSayi1.Text) | String.IsNullOrWhiteSpace(tbxSayi1.Text) & String.IsNullOrEmpty(tbxSayi2.Text) | String.IsNullOrWhiteSpace(tbxSayi2.Text))
            {
                lblMessageError.Text = "Lütfen ilgili alanları doldurun";
            }
            else
            {
                int s1 = Convert.ToInt32(tbxSayi1.Text);
                int s2 = Convert.ToInt32(tbxSayi2.Text);

                if (rbtnKare.Checked)
                {
                    lblMessageError.Text = Convert.ToString(kare(s1, s2));
                }
                if (rbtnKup.Checked)
                {
                    lblMessageError.Text = Convert.ToString(kup(s1, s2));
                }
            }
        }
    }
}
