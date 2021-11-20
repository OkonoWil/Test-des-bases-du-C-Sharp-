
namespace Tp_Parite
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.Label();
            this.txt_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_nombre.Location = new System.Drawing.Point(139, 34);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(227, 29);
            this.txt_nombre.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.Menu;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button.Location = new System.Drawing.Point(393, 34);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(83, 29);
            this.button.TabIndex = 2;
            this.button.Text = "Tester";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // txt_result
            // 
            this.txt_result.AutoSize = true;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_result.ForeColor = System.Drawing.Color.Blue;
            this.txt_result.Location = new System.Drawing.Point(119, 107);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(0, 20);
            this.txt_result.TabIndex = 3;
            // 
            // txt_erreur
            // 
            this.txt_erreur.AutoSize = true;
            this.txt_erreur.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Italic);
            this.txt_erreur.ForeColor = System.Drawing.Color.Red;
            this.txt_erreur.Location = new System.Drawing.Point(59, 107);
            this.txt_erreur.Name = "txt_erreur";
            this.txt_erreur.Size = new System.Drawing.Size(0, 19);
            this.txt_erreur.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 191);
            this.Controls.Add(this.txt_erreur);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label txt_result;
        private System.Windows.Forms.Label txt_erreur;
    }
}

