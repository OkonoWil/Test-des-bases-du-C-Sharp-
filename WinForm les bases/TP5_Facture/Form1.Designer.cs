
namespace TP5_Facture
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_effacer = new System.Windows.Forms.Button();
            this.rb_20 = new System.Windows.Forms.RadioButton();
            this.rb_7 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Quantite = new System.Windows.Forms.TextBox();
            this.txt_prixUnitaireHT = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MontantHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MontantTVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MontantTTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_montantHT = new System.Windows.Forms.TextBox();
            this.txt_montantTVA = new System.Windows.Forms.TextBox();
            this.txt_NetPayer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_ajouter);
            this.groupBox1.Controls.Add(this.bt_effacer);
            this.groupBox1.Controls.Add(this.rb_20);
            this.groupBox1.Controls.Add(this.rb_7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Quantite);
            this.groupBox1.Controls.Add(this.txt_prixUnitaireHT);
            this.groupBox1.Controls.Add(this.txt_designation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article";
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(474, 79);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(160, 34);
            this.bt_ajouter.TabIndex = 4;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_effacer
            // 
            this.bt_effacer.Location = new System.Drawing.Point(670, 79);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(156, 34);
            this.bt_effacer.TabIndex = 4;
            this.bt_effacer.Text = "Effacer";
            this.bt_effacer.UseVisualStyleBackColor = true;
            this.bt_effacer.Click += new System.EventHandler(this.bt_effacer_Click);
            // 
            // rb_20
            // 
            this.rb_20.AutoSize = true;
            this.rb_20.Location = new System.Drawing.Point(747, 41);
            this.rb_20.Name = "rb_20";
            this.rb_20.Size = new System.Drawing.Size(50, 19);
            this.rb_20.TabIndex = 3;
            this.rb_20.TabStop = true;
            this.rb_20.Text = "20%";
            this.rb_20.UseVisualStyleBackColor = true;
            // 
            // rb_7
            // 
            this.rb_7.AutoSize = true;
            this.rb_7.Location = new System.Drawing.Point(630, 41);
            this.rb_7.Name = "rb_7";
            this.rb_7.Size = new System.Drawing.Size(43, 19);
            this.rb_7.TabIndex = 3;
            this.rb_7.TabStop = true;
            this.rb_7.Text = "7%";
            this.rb_7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Taux TVA";
            // 
            // txt_Quantite
            // 
            this.txt_Quantite.Location = new System.Drawing.Point(162, 92);
            this.txt_Quantite.Name = "txt_Quantite";
            this.txt_Quantite.Size = new System.Drawing.Size(173, 21);
            this.txt_Quantite.TabIndex = 1;
            this.txt_Quantite.Text = "0";
            this.txt_Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_prixUnitaireHT
            // 
            this.txt_prixUnitaireHT.Location = new System.Drawing.Point(162, 61);
            this.txt_prixUnitaireHT.Name = "txt_prixUnitaireHT";
            this.txt_prixUnitaireHT.Size = new System.Drawing.Size(173, 21);
            this.txt_prixUnitaireHT.TabIndex = 1;
            this.txt_prixUnitaireHT.Text = "0";
            this.txt_prixUnitaireHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(162, 24);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(173, 21);
            this.txt_designation.TabIndex = 1;
            this.txt_designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prix unitaire HT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Designation,
            this.Prix,
            this.Quantite,
            this.MontantHT,
            this.MontantTVA,
            this.MontantTTC});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(49, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(842, 152);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Designation
            // 
            this.Designation.Text = "Designation";
            this.Designation.Width = 250;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix unitaire";
            this.Prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Prix.Width = 120;
            // 
            // Quantite
            // 
            this.Quantite.Text = "Quantité";
            this.Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantite.Width = 90;
            // 
            // MontantHT
            // 
            this.MontantHT.Text = "Montant HT";
            this.MontantHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MontantHT.Width = 120;
            // 
            // MontantTVA
            // 
            this.MontantTVA.Text = "Montant TVA";
            this.MontantTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MontantTVA.Width = 100;
            // 
            // MontantTTC
            // 
            this.MontantTTC.Text = "Montant TTC";
            this.MontantTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MontantTTC.Width = 150;
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bt_supprimer.Location = new System.Drawing.Point(158, 340);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(160, 27);
            this.bt_supprimer.TabIndex = 4;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bt_modifier.Location = new System.Drawing.Point(390, 340);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(160, 27);
            this.bt_modifier.TabIndex = 4;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bt_quitter.Location = new System.Drawing.Point(625, 340);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(160, 27);
            this.bt_quitter.TabIndex = 4;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total des montants (HT)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total des Montants (TVA)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Net à payer";
            // 
            // txt_montantHT
            // 
            this.txt_montantHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montantHT.Location = new System.Drawing.Point(258, 407);
            this.txt_montantHT.Name = "txt_montantHT";
            this.txt_montantHT.ReadOnly = true;
            this.txt_montantHT.Size = new System.Drawing.Size(267, 24);
            this.txt_montantHT.TabIndex = 1;
            this.txt_montantHT.Text = "0";
            this.txt_montantHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_montantTVA
            // 
            this.txt_montantTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montantTVA.Location = new System.Drawing.Point(258, 455);
            this.txt_montantTVA.Name = "txt_montantTVA";
            this.txt_montantTVA.ReadOnly = true;
            this.txt_montantTVA.Size = new System.Drawing.Size(267, 24);
            this.txt_montantTVA.TabIndex = 1;
            this.txt_montantTVA.Text = "0";
            this.txt_montantTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_NetPayer
            // 
            this.txt_NetPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NetPayer.Location = new System.Drawing.Point(258, 505);
            this.txt_NetPayer.Name = "txt_NetPayer";
            this.txt_NetPayer.ReadOnly = true;
            this.txt_NetPayer.Size = new System.Drawing.Size(267, 24);
            this.txt_NetPayer.TabIndex = 1;
            this.txt_NetPayer.Text = "0";
            this.txt_NetPayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_NetPayer);
            this.Controls.Add(this.txt_montantTVA);
            this.Controls.Add(this.txt_montantHT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Facture";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_effacer;
        private System.Windows.Forms.RadioButton rb_20;
        private System.Windows.Forms.RadioButton rb_7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Quantite;
        private System.Windows.Forms.TextBox txt_prixUnitaireHT;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_montantHT;
        private System.Windows.Forms.TextBox txt_montantTVA;
        private System.Windows.Forms.TextBox txt_NetPayer;
        private System.Windows.Forms.ColumnHeader Designation;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.ColumnHeader Quantite;
        private System.Windows.Forms.ColumnHeader MontantHT;
        private System.Windows.Forms.ColumnHeader MontantTVA;
        private System.Windows.Forms.ColumnHeader MontantTTC;
    }
}

