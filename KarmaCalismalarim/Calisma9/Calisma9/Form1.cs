using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma9
{
    public partial class frmZarAtmaOyunu : Form
    {
        public frmZarAtmaOyunu()
        {
            InitializeComponent();
            btnZarAt.Enabled = false;
        }

        int[] oyuncuSayisi;
        
        Random rand = new Random();

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxOyuncuSayisi.Text) | String.IsNullOrWhiteSpace(tbxSetSayisi.Text))
            {
                MessageBox.Show(
                    lblMessageError.Text = "Alanları Boş Bırakma...!!!"
                    );  
            }
            else
            {
                lblMessageError.Text = "Afferim Sana :)";
                oyuncuSayisi = new int[Convert.ToInt32(tbxOyuncuSayisi.Text)];
                tbxOyuncuSayisi.Enabled = false;
                tbxSetSayisi.Enabled = false;
                btnZarAt.Enabled = true;

            }
        }
        int i = 0;
        int j = 0;
        int k = 0;
        int l = 0;
        int buyuk = 0;

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            int random = rand.Next(1, 6);
            dataGridView1.ColumnCount = oyuncuSayisi.Length;

            if (i < dataGridView1.ColumnCount)
            {
                lblOyuncu.Text = Convert.ToString(i + 1);
                oyuncuSayisi[i] += random;

                lblPuan.Text = Convert.ToString(oyuncuSayisi[i] + 1);
                
                dataGridView1.Columns[i].Name = i + 1 + ". Oyuncu";

                i++;
                dataGridView1.Rows[0].Cells[i-1].Value = lblPuan.Text;
            }
            else
            {
                if (k <= Convert.ToInt32(tbxSetSayisi.Text))
                {
                    buyuk = oyuncuSayisi[0];
                    if (j < dataGridView1.ColumnCount)
                    {
                        lblOyuncu.Text = Convert.ToString(j + 1);
                        oyuncuSayisi[j] += random;

                        lblPuan.Text = Convert.ToString(oyuncuSayisi[j] + 1);
                        //String[] a = new String[] {Convert.ToString(oyuncuSayisi[j])};
                        if (l >= Convert.ToInt32(tbxOyuncuSayisi.Text) * Convert.ToInt32(tbxSetSayisi.Text))
                        {
                            for (int i = 0; i < oyuncuSayisi.Length; i++)
                            {
                                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) > buyuk)
                                {
                                    buyuk = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                                }
                            }
                            lblMessageError.ForeColor = Color.Red;

                            lblMessageError.Text = "Kazana kişi:" +  buyuk;

                            btnZarAt.Enabled = false;

                            btnOnayla.Enabled = false;
                        }
                        else
                        {
                            dataGridView1.Rows[0].Cells[j].Value = lblPuan.Text;
                            l++;
                        }

                        j++;
                        k++;
                    }
                    else
                    {
                        j = 0;
                    }
                }
                else
                {
                    k = 0;
                }
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle");
            this.Close();
        }
    }
}
