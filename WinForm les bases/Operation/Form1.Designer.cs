
namespace Operation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_nombre3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_somme = new System.Windows.Forms.TextBox();
            this.txt_moyenne = new System.Windows.Forms.TextBox();
            this.txt_produit = new System.Windows.Forms.TextBox();
            this.tex_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(286, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(508, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre 3";
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(41, 78);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(138, 20);
            this.txt_nombre1.TabIndex = 3;
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Location = new System.Drawing.Point(251, 78);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(140, 20);
            this.txt_nombre2.TabIndex = 3;
            // 
            // txt_nombre3
            // 
            this.txt_nombre3.Location = new System.Drawing.Point(473, 78);
            this.txt_nombre3.Name = "txt_nombre3";
            this.txt_nombre3.Size = new System.Drawing.Size(138, 20);
            this.txt_nombre3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(277, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(175, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Le minimum est ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(175, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Le maximum est";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(175, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "La somme est";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(175, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "La moyenne est";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(175, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Le produit est";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(347, 207);
            this.txt_min.Name = "txt_min";
            this.txt_min.ReadOnly = true;
            this.txt_min.Size = new System.Drawing.Size(125, 20);
            this.txt_min.TabIndex = 6;
            this.txt_min.Text = "0";
            this.txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(347, 246);
            this.txt_max.Name = "txt_max";
            this.txt_max.ReadOnly = true;
            this.txt_max.Size = new System.Drawing.Size(125, 20);
            this.txt_max.TabIndex = 6;
            this.txt_max.Text = "0";
            this.txt_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_somme
            // 
            this.txt_somme.Location = new System.Drawing.Point(347, 284);
            this.txt_somme.Name = "txt_somme";
            this.txt_somme.ReadOnly = true;
            this.txt_somme.Size = new System.Drawing.Size(125, 20);
            this.txt_somme.TabIndex = 6;
            this.txt_somme.Text = "0";
            this.txt_somme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_moyenne
            // 
            this.txt_moyenne.Location = new System.Drawing.Point(347, 321);
            this.txt_moyenne.Name = "txt_moyenne";
            this.txt_moyenne.ReadOnly = true;
            this.txt_moyenne.Size = new System.Drawing.Size(125, 20);
            this.txt_moyenne.TabIndex = 6;
            this.txt_moyenne.Text = "0";
            this.txt_moyenne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_produit
            // 
            this.txt_produit.Location = new System.Drawing.Point(347, 361);
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.ReadOnly = true;
            this.txt_produit.Size = new System.Drawing.Size(125, 20);
            this.txt_produit.TabIndex = 6;
            this.txt_produit.Text = "0";
            this.txt_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_err
            // 
            this.tex_err.AutoSize = true;
            this.tex_err.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Italic);
            this.tex_err.ForeColor = System.Drawing.Color.Red;
            this.tex_err.Location = new System.Drawing.Point(37, 416);
            this.tex_err.Name = "tex_err";
            this.tex_err.Size = new System.Drawing.Size(0, 16);
            this.tex_err.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.tex_err);
            this.Controls.Add(this.txt_produit);
            this.Controls.Add(this.txt_moyenne);
            this.Controls.Add(this.txt_somme);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre3);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opération";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_nombre3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_somme;
        private System.Windows.Forms.TextBox txt_moyenne;
        private System.Windows.Forms.TextBox txt_produit;
        private System.Windows.Forms.Label tex_err;
    }
}

