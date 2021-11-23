using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_Facture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_effacer_Click(object sender, EventArgs e)
        {
            txt_designation.Text = "";
            txt_prixUnitaireHT.Text = "0";
            txt_Quantite.Text = "0";
            rb_7.Checked = false;
            rb_20.Checked = false;
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            //Calculer le montant HT TVA TTC
            double mht = 0, mtva = 0, mttc = 0;
            double prix = double.Parse(txt_prixUnitaireHT.Text);
            int qte = int.Parse(txt_Quantite.Text);
            mht = prix * qte;
            if (rb_7.Checked)
                mtva = mht * 0.07;
            else if (rb_20.Checked)
                mtva = mht * 0.2;
            mttc = mtva + mht;

            // Construire un élément
            ListViewItem item = new ListViewItem();
            item.Text = txt_designation.Text;
            item.SubItems.Add(txt_prixUnitaireHT.Text);
            item.SubItems.Add(txt_Quantite.Text);
            item.SubItems.Add(mht.ToString());
            item.SubItems.Add(mtva.ToString());
            item.SubItems.Add(mttc.ToString());

            //Ajouter un element à la liste
            listView1.Items.Add(item);

            //Calculer total des montant ht tva ttc
            calculTotal();

        }

        public void calculTotal()
        {
            //Calculer total des montant ht tva ttc
            double t_mht = 0, t_mtva = 0, net = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                t_mht += double.Parse(listView1.Items[i].SubItems[3].Text);
                t_mtva += double.Parse(listView1.Items[i].SubItems[4].Text);
            }
            net = t_mtva + t_mht;

            txt_montantHT.Text = t_mht.ToString();
            txt_montantTVA.Text = t_mtva.ToString();
            txt_NetPayer.Text = net.ToString();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1)
            {
                int selectedIndice = listView1.SelectedIndices[0];
                listView1.Items[selectedIndice].Remove();
                calculTotal();
            }
            else
            {
                MessageBox.Show("Selectionnez un élément");
            }
        }



        int indiceToEdit = -1;


        private void bt_modifier_Click(object sender, EventArgs e)
        {
            
            if (indiceToEdit == -1)
            {
                if (listView1.SelectedIndices.Count == 1)
                {
                    indiceToEdit = listView1.SelectedIndices[0];
                    txt_designation.Text = listView1.Items[indiceToEdit].SubItems[0].Text;
                    txt_prixUnitaireHT.Text = listView1.Items[indiceToEdit].SubItems[1].Text;
                    txt_Quantite.Text = listView1.Items[indiceToEdit].SubItems[2].Text;

                    double mht = double.Parse(listView1.Items[indiceToEdit].SubItems[3].Text);
                    double mtva = double.Parse(listView1.Items[indiceToEdit].SubItems[4].Text);
                    if (mht * 0.2 == mtva)
                        rb_20.Checked = true;
                    else
                        rb_7.Checked = true;

                    bt_ajouter.Enabled = false;
                    bt_effacer.Enabled = false;
                    bt_modifier.Enabled = true;
                    bt_quitter.Enabled = false;
                    bt_supprimer.Enabled = false;

                    bt_modifier.Text = "Valider";
                }
                else
                {
                    MessageBox.Show("Selectionnez un élément");
                }

                   
            }
            else
            {

                double mht = 0, mtva = 0, mttc = 0;
                double prix = double.Parse(txt_prixUnitaireHT.Text);
                int qte = int.Parse(txt_Quantite.Text);
                mht = prix * qte;
                if (rb_7.Checked)
                    mtva = mht * 0.07;
                else if (rb_20.Checked)
                    mtva = mht * 0.2;
                mttc = mtva + mht;

                listView1.Items[indiceToEdit].SubItems[0].Text = txt_designation.Text;
                listView1.Items[indiceToEdit].SubItems[1].Text = txt_prixUnitaireHT.Text;
                listView1.Items[indiceToEdit].SubItems[2].Text = txt_Quantite.Text;
                listView1.Items[indiceToEdit].SubItems[3].Text = mht.ToString();
                listView1.Items[indiceToEdit].SubItems[4].Text = mtva.ToString();
                listView1.Items[indiceToEdit].SubItems[5].Text = mttc.ToString();

                bt_modifier.Text = "Modifier";

                calculTotal();

                bt_ajouter.Enabled = true;
                bt_effacer.Enabled = true;
                bt_modifier.Enabled = true;
                bt_quitter.Enabled = true;
                bt_supprimer.Enabled = true;

                indiceToEdit = -1;
            }
            
        }
    }
}
