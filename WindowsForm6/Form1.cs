using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tutar_Click(object sender, EventArgs e)
        {

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            if(checkBox_cay.Checked)
            {
                tutar += 2;
            }
            if (checkBox_kahve.Checked)
            {
                tutar += 5;
            }
            if (checkBox_hamburger.Checked)
            {
                tutar += 15;
            }
            if (checkBox_pizza.Checked)
            {
                tutar += 20;
            }
            lbl_tutar.Text = tutar.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
