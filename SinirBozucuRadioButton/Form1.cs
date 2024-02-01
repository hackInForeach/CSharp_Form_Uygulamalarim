using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinirBozucuRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int tut = rand.Next(1,11);

            if (tut == 1)
                rbtn9.Checked = true;
            if (tut == 2)
                rbtn10.Checked = true;
            if (tut == 3)
                rbtn7.Checked = true;
            if (tut == 4)
                rbtn8.Checked = true;
            if (tut == 5)
                rbtn6.Checked = true;
            if (tut == 6)
                rbtn5.Checked = true;
            if (tut == 7)
                rbtn3.Checked = true;
            if (tut == 8)
                rbtn4.Checked = true;
            if (tut == 9)
                rbtn1.Checked = true;
            if (tut == 10)
                rbtn2.Checked = true;

        }
    }
}
