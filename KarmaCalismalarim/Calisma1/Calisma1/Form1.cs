using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma1
{
    public partial class frmEmeklilik : Form
    {
        public frmEmeklilik()
        {
            InitializeComponent();
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(tbxYas.Text) | rbtnErkek.Checked == false & rbtnKadin.Checked == false)
            {
                lblSonuc.Text = "İlgili alanları doldurunuz.";
            }
            else
            {
                int yas = Convert.ToInt32(tbxYas.Text);
                int kadinEmekli = 60;
                int erkekEmekli = 65;
                
                if (rbtnErkek.Checked)
                {
                    lblSonuc.Text =
                           yas >= erkekEmekli ?
                           "Emekli olabilirsiniz":
                           (65 - yas) + " yil sonra emeklisiniz."
                        ;
                }
                else if (rbtnKadin.Checked)
                {
                    lblSonuc.Text =
                           yas >= kadinEmekli ?
                           "Emekli olabilirsiniz" :
                           (60 - yas) + " yil sonra emeklisiniz."
                        ;
                }
            }


        }
    }
}

