using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSifrelenmisMetin_Click(object sender, EventArgs e)
        {
            // txbox ların boşluk kontrolu
            if (string.IsNullOrWhiteSpace(txtKey.Text) | string.IsNullOrWhiteSpace(txtSifrelenecekMetin.Text))
            {
                lblSifrelenmisMetin.Text = "Lütfen boş alan bırakmayınız!!";
                lblCozulmusMetin.Text = lblSifrelenmisMetin.Text;
            }
            else
            {
                int anahtar = Convert.ToInt32(txtKey.Text);
                string sifreleneceKelime = txtSifrelenecekMetin.Text.ToLower();
                bool rbtn1 = rbtnIngZero.Checked;
                bool rbtn2 = rbtnTrZero.Checked;

                lblSifrelenmisMetin.Text =
                    sifreleme(
                        mod(anahtar, rbtnTrZero.Checked, rbtnIngZero.Checked),
                        alfabe(rbtnIngZero.Checked, rbtnTrZero.Checked),
                        sifreleneceKelime, rbtn1, rbtn2
                    );
            }
        }
        // ilgili parametrele ile sezar şifreleme işlemi (ileri)
        public string sifreleme(int anahtar, string zeroAlfabe, string sifreleneceKelime, bool rbtn1, bool rbtn2)
        {
            string sifrelimetin = "";
            rbtn1 = rbtnIngZero.Checked;
            rbtn2 = rbtnTrZero.Checked;

            for (int i = 0; i < sifreleneceKelime.Length; i++)
            {
                char krtr = sifreleneceKelime[i]; // metindeki karakteri al
                int index = zeroAlfabe.IndexOf(krtr); // karakterin alfabe içindeki konumunu bul
                if (index != -1)
                {
                    index = (index + anahtar) % zeroAlfabe.Length; // yeni konumu hesapla
                    
                    // rbtn btona göre sayının moddan büyüklüğünün kontrolü kontrolu
                    if (rbtn2)
                    {
                        if (index > zeroAlfabe.Length)
                        {
                            index -= 29;
                        }
                    }
                    else if (rbtn1)
                    {
                        if (index > zeroAlfabe.Length)
                        {
                            index -= 26;
                        }
                    }
                    krtr = zeroAlfabe[index]; // yeni karakteri al
                }
                sifrelimetin += krtr; // şifrelenmiş karakterleri ekle
            }
            return sifrelimetin.ToUpper();
        }
        // radio buton check ine göre string dönen lafabeler
        public string alfabe(bool rbtn1, bool rbtn2)
        {
            rbtn1 = rbtnIngZero.Checked;
            rbtn2 = rbtnTrZero.Checked;

            string zeroAlfabe = "";

            if (rbtn1)
            {
                zeroAlfabe = "abcdefghijklmnopqrstuvwxyz"; //ing mod 26
            }
            if (rbtn2)
            {
                zeroAlfabe = "abcçdefgğhıijklmnoöprsştuüvyz"; // tr mo29
            }
            return zeroAlfabe;
        }
        // radio buton check ıne göre girile büyük sayını modunun alınması
        public int mod(int key, bool rbtn1, bool rbtn2)
        {
            int modTr = 29;
            int modIng = 26;
            rbtn1 = rbtnTrZero.Checked;
            rbtn2 = rbtnIngZero.Checked;

            if (rbtn1 & key > modTr)
            {
                key %= modTr;
            }
            if (rbtn2 & key > modIng)
            {
                key %= modIng;
            }
            return key;
        }
        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            // txbox ların boşluk kontrolu
            if (string.IsNullOrWhiteSpace(txtKey.Text) | string.IsNullOrWhiteSpace(txtSifrelenecekMetin.Text))
            {
                lblSifrelenmisMetin.Text = "Lütfen boş alan bırakmayınız!!";
                lblCozulmusMetin.Text = lblSifrelenmisMetin.Text;
            }
            else
            {
                // gerekli girdilerin alınması
                int anahtar = Convert.ToInt32(txtKey.Text);
                string deSifreleneceKelime = lblSifrelenmisMetin.Text.ToLower();
                bool rbtn1 = rbtnIngZero.Checked;
                bool rbtn2 = rbtnTrZero.Checked;
                lblCozulmusMetin.Text =
                   deSifreleme(
                       mod(anahtar, rbtnTrZero.Checked, rbtnIngZero.Checked),
                       alfabe(rbtnIngZero.Checked, rbtnTrZero.Checked),
                       deSifreleneceKelime, rbtn1, rbtn2
                       );
                txtKey.Text = "";
                txtSifrelenecekMetin.Text = "";
            }
        }
        // şifrelenen metnin çözülmesi (geri)
        public string deSifreleme(int anahtar, string zeroAlfabe, string deSifreleneceKelime, bool rbtn1, bool rbtn2)
        {
            rbtn1 = rbtnIngZero.Checked;
            rbtn2 = rbtnTrZero.Checked;
            string sifrelimetin = "";
            for (int i = 0; i < deSifreleneceKelime.Length; i++)
            {
                char krtr = deSifreleneceKelime[i]; // metindeki karakteri al
                int index = zeroAlfabe.IndexOf(krtr); // karakterin alfabe içindeki konumunu bul
                if (index != -1)
                {
                    index = (index - anahtar) % zeroAlfabe.Length; // yeni konumu hesapla
                    
                    // rbtn btona göre sayının negatifliğinin kontrolu
                    if (rbtn2)
                    {
                        if (index < 0)
                        {
                            index += 29;
                        }
                    }
                    else if (rbtn1)
                    {
                        if (index < 0)
                        {
                            index += 26;
                        }
                    }

                    krtr = zeroAlfabe[index]; // yeni karakteri al
                }
                sifrelimetin += krtr; // şifrelenmiş karakterleri ekle
            }
            return sifrelimetin.ToUpper();
        }
    }
}





