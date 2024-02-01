using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxCinsiyet.Items.Add("Erkek");
            cbxCinsiyet.Items.Add("Kadın");
            cbxCinsiyet.Items.Add("Diğer");
            cbxCinsiyet.Items.Add("Belirtmek istemiyorum");

            cbxYas.Items.Add("18'den küçük");
            cbxYas.Items.Add("18 - 24");
            cbxYas.Items.Add("25 - 44");
            cbxYas.Items.Add("45 ve üzeri");

            cbxSpor.Items.Add("Futol");
            cbxSpor.Items.Add("Basketbol");
            cbxSpor.Items.Add("Voleybol");
            cbxSpor.Items.Add("Tenis");

            cbxMuzik.Items.Add("Pop");
            cbxMuzik.Items.Add("Rock");
            cbxMuzik.Items.Add("Klasik");
            cbxMuzik.Items.Add("Hip - Hop");

            cbxFilm.Items.Add("Aksiyon");
            cbxFilm.Items.Add("Komedi");
            cbxFilm.Items.Add("Romantik");
            cbxFilm.Items.Add("Belgesel");

            cbxTatli.Items.Add("Çikolata");
            cbxTatli.Items.Add("Dondurma");
            cbxTatli.Items.Add("Kek");
            cbxTatli.Items.Add("Muffin");

            cbxKitap.Items.Add("Polisiye");
            cbxKitap.Items.Add("Bilimkurgu");
            cbxKitap.Items.Add("Klasik Edebiyat");
            cbxKitap.Items.Add("Gizem");

            cbxHayvan.Items.Add("Kaplumbağa");
            cbxHayvan.Items.Add("Kedi");
            cbxHayvan.Items.Add("Tavşan");
            cbxHayvan.Items.Add("Kuş");


        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            int cinsiyet=cbxCinsiyet.SelectedIndex;
            int yas=cbxYas.SelectedIndex;
            int spor=cbxSpor.SelectedIndex;
            int muzik=cbxMuzik.SelectedIndex;
            int film=cbxFilm.SelectedIndex;
            int tatli=cbxTatli.SelectedIndex;
            int kitap=cbxKitap.SelectedIndex;
            int hayvan=cbxHayvan.SelectedIndex;

            if (string.IsNullOrWhiteSpace(tbxIsim.Text))
            {
                MessageBox.Show("İsim boş brakılamaz!!...");
            }
            else
            {
                if (cinsiyet < 0 | yas < 0 | spor < 0 | muzik < 0 | film < 0 | tatli < 0 | kitap < 0 | hayvan < 0)
                   MessageBox.Show("Her alanı seç!!");
                    
                else
                {

                    // lblCikti.Text =
                    MessageBox.Show(
                                    "Adı:  " + tbxIsim.Text + "\n" +
                                    "Cinsiyeti:  " + cbxCinsiyet.Text + "\n" +
                                    "Yaş Aralığı:  " + cbxYas.Text + "\n" +
                                    "En Sevdiği Spor:  " + cbxSpor.Text + "\n" +
                                    "En Sevdiği Müzik:  " + cbxMuzik.Text + "\n" +
                                    "En Sevdiği Film:  " + cbxFilm.Text + "\n" +
                                    "En Sevdiği Tatlı:  " + cbxTatli.Text + "\n" +
                                    "En Sevdiği Kitap:  " + cbxKitap.Text + "\n" +
                                    "En Sevdiği Hayvan:  " + cbxHayvan.Text
                                    );
                }
            }
            tbxIsim.Text = "";
            cbxCinsiyet.Text = "";
            cbxYas.Text = "";
            cbxSpor.Text = "";
            cbxMuzik.Text = "";
            cbxFilm.Text = "";
            cbxTatli.Text = "";
            cbxKitap.Text = "";
            cbxHayvan.Text = "";

        }
    }
}
