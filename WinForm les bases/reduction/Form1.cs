using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal montant;
            if(decimal.TryParse(txt_montant.Text, out montant) && montant >= 0)
            {
                txt_err.Text = "";

                //Calcul du taux de réduction
                int taux;
                if (montant <= 1000)
                    taux = 0;
                else if (montant <= 3000)
                    taux = 5;
                else if (montant <= 4000)
                    taux = 10;
                else if (montant <= 5000)
                    taux = 15;
                else
                    taux = 20;
                txt_taux.Text = taux.ToString() + "%";

                //Calcul du montant total à payer
                decimal total = montant - (montant * taux) / 100;
                txt_total.Text = total.ToString();
            }
            else
            {
                txt_err.Text = "Erreur : saisir un montant valide";
                txt_taux.Text = "";
                txt_total.Text = "";
            }
        }
    }
}
