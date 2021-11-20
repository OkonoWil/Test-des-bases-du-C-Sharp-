using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nb1, nb2, nb3;
            if(double.TryParse(txt_nombre1.Text, out nb1) && double.TryParse(txt_nombre2.Text, out nb2) && double.TryParse(txt_nombre3.Text, out nb3))
            {
                tex_err.Text = "";

                double max = Math.Max(Math.Max(nb1, nb2), nb3);
                txt_max.Text = max.ToString();

                double min = Math.Min(Math.Min(nb1, nb2), nb3);
                txt_min.Text = min.ToString();

                double moy = (nb1 + nb2 + nb3) / 3;
                txt_moyenne.Text = moy.ToString();

                double produit = nb1 * nb2 * nb3;
                txt_produit.Text = produit.ToString();

                double somme = nb1 + nb2 + nb3;
                txt_somme.Text = somme.ToString();
            }
            else
            {
                tex_err.Text = "Vérifier les nombres saisi";
                txt_max.Text = "";
                txt_min.Text = "";
                txt_moyenne.Text = "";
                txt_produit.Text = "";
                txt_somme.Text = "";
            }
                
        }
    }
}
