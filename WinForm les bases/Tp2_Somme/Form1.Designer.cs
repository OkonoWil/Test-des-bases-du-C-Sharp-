
namespace Tp2_Somme
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
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.txt_errer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(115, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somme de deux nombre :";
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_nombre1.Location = new System.Drawing.Point(24, 88);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(118, 29);
            this.txt_nombre1.TabIndex = 1;
            this.txt_nombre1.Text = "0";
            this.txt_nombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(148, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_nombre2.Location = new System.Drawing.Point(175, 88);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(122, 29);
            this.txt_nombre2.TabIndex = 3;
            this.txt_nombre2.Text = "0";
            this.txt_nombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(303, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(331, 130);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(117, 28);
            this.button.TabIndex = 6;
            this.button.Text = "Resultat";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.result.Location = new System.Drawing.Point(331, 88);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(117, 29);
            this.result.TabIndex = 7;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_errer
            // 
            this.txt_errer.AutoSize = true;
            this.txt_errer.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_errer.ForeColor = System.Drawing.Color.Red;
            this.txt_errer.Location = new System.Drawing.Point(21, 184);
            this.txt_errer.Name = "txt_errer";
            this.txt_errer.Size = new System.Drawing.Size(0, 16);
            this.txt_errer.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 249);
            this.Controls.Add(this.txt_errer);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Somme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label txt_errer;
    }
}

