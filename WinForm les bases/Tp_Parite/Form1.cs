using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Parite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            long nbr;
            if (long.TryParse(txt_nombre.Text, out nbr))
            {
                txt_erreur.Text = "";
                if (nbr % 2 == 0)
                {
                    txt_result.Text = nbr + " est un entier pair.";
                }
                else
                {
                    txt_result.Text = nbr + " est un entier impair.";
                }
            }
            else
            {
                txt_erreur.Text = "Erreur : veillez saissir un nombre valide (un entier)";
                txt_result.Text = "";
            }
        }
    }
}
