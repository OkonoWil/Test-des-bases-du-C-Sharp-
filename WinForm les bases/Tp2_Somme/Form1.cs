using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Somme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            decimal nbr1, nbr2, nbr;
            if (decimal.TryParse(txt_nombre1.Text, out nbr1) && decimal.TryParse(txt_nombre2.Text, out nbr2))
            {
                nbr = nbr1 + nbr2;
                result.Text = nbr.ToString();
                txt_errer.Text = "";
            }
            else
            {
                txt_errer.Text = "Une erreur c'est produit, veillez saisir des nombres valide";
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
