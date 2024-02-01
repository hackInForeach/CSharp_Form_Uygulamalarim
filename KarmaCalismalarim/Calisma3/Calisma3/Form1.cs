using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma3
{
    public partial class frmAsalHeader : Form
    {
        public frmAsalHeader()
        {
            InitializeComponent();
        }

        public void asal(bool x)
        {
            if (x)
            {
                lblSonuc.Text = "Asal";
            }
            else
            {
                lblSonuc.Text = "Asal Değil";
            }

        }
        public bool asal(int x)
        {
            bool asal = true;
            if (x==0|x==1)
            {
                asal = false;
            }
            else
            {
                for (int i = x - 1; i > 1; i--)
                {

                    if (x % i == 0)
                    {
                        asal = false;
                        break;
                    }

                }
            }
            
            return asal;

        }

        private void tbxAsalSayi1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxAsalSayi1.Text) & String.IsNullOrWhiteSpace(tbxAsalSayi1.Text))
            {
                
                lblSonuc.Text = "----";
            }
            else
            {
                asal(asal(Convert.ToInt32(tbxAsalSayi1.Text)));
            }

        }
    }
}
