using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenKelimeKaçHarfli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxMetin_TextChanged(object sender, EventArgs e)
        {

            lblSayac.Text = Convert.ToString(tbxMetin.Text.Length);
        
        }
    }
}
