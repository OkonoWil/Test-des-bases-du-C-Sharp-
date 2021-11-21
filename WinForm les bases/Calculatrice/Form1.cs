using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_calculer_Click(object sender, EventArgs e)
        {
            decimal nb1 = decimal.Parse(txt_nombre1.Text);
            decimal nb2 = decimal.Parse(txt_nombre2.Text);
            decimal result;
            if (rb_addition.Checked)
            {
                result = nb1 + nb2;
                txt_result.Text = result.ToString();
            }
            else if (rb_division.Checked)
            {
                result = nb1 / nb2;
                txt_result.Text = result.ToString();
            }
            else if (rb_multiplication.Checked)
            {
                result = nb1 * nb2;
                txt_result.Text = result.ToString();
            }
            else if (rb_soustraction.Checked)
            {
                result = nb1 - nb2;
                txt_result.Text = result.ToString();
            }
        }
    }
}
