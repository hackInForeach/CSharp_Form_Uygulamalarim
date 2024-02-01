using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma6
{
    public partial class frmHeader : Form
    {
        public frmHeader()
        {
            InitializeComponent();
        }
        public bool tbx1()
        {
            return String.IsNullOrWhiteSpace(tbxSayi1.Text);
        }
        public bool tbx2()
        {
            return String.IsNullOrWhiteSpace(tbxSayi2.Text);
        }
        public bool tbx3()
        {
            return String.IsNullOrWhiteSpace(tbxSayi3.Text);
        }
        public bool tbx4()
        {
            return String.IsNullOrWhiteSpace(tbxSayi4.Text);
        }
        private void rbtnTopla2_CheckedChanged(object sender, EventArgs e)
        {

            tbxSayi3.Enabled = false;
            tbxSayi4.Enabled = false;

            if (tbx1() & tbx2())
            {
                lblMessage.Text = "Lütfen boş alanları doldur.";
            }
            else
            {
                if (tbxSayi2.Text != "")
                {
                    lblMessage.Text = Convert.ToString(
                                        Convert.ToInt32(tbxSayi1.Text) +
                                        Convert.ToInt32(tbxSayi2.Text)
                                        );
                }

            }
        }

        private void rbtnTopla3_CheckedChanged(object sender, EventArgs e)
        {

            tbxSayi3.Enabled = true;
            tbxSayi4.Enabled = false;
            if (tbx1() & tbx2() & tbx3())
            {
                lblMessage.Text = "Lütfen boş alanları doldur.";
            }
            else
            {
                if (tbxSayi3.Text != "")
                {
                    lblMessage.Text = Convert.ToString(
                                        Convert.ToInt32(tbxSayi1.Text) +
                                        Convert.ToInt32(tbxSayi2.Text) +
                                        Convert.ToInt32(tbxSayi3.Text)
                                        );
                }

            }
        }

        private void rbtnTopla4_CheckedChanged(object sender, EventArgs e)
        {
            tbxSayi4.Enabled = true;
            if (tbx1() & tbx2() & tbx3() & tbx4())
            {
                lblMessage.Text = "Lütfen boş alanları doldur.";
            }
            else
            {
                if (tbxSayi4.Text != "")
                {
                    lblMessage.Text = Convert.ToString(
                                        Convert.ToInt32(tbxSayi1.Text) +
                                        Convert.ToInt32(tbxSayi2.Text) +
                                        Convert.ToInt32(tbxSayi3.Text) +
                                        Convert.ToInt32(tbxSayi4.Text)
                                        );
                }
            }
        }
    }
}
