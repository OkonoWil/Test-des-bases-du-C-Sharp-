
namespace Calculatrice
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
            this.txt_result = new System.Windows.Forms.TextBox();
            this.bt_calculer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_multiplication = new System.Windows.Forms.RadioButton();
            this.rb_division = new System.Windows.Forms.RadioButton();
            this.rb_soustraction = new System.Windows.Forms.RadioButton();
            this.rb_addition = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultat";
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre1.Location = new System.Drawing.Point(189, 34);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(285, 26);
            this.txt_nombre1.TabIndex = 1;
            this.txt_nombre1.Text = "0";
            this.txt_nombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre2.Location = new System.Drawing.Point(189, 82);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(285, 26);
            this.txt_nombre2.TabIndex = 1;
            this.txt_nombre2.Text = "0";
            this.txt_nombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(189, 127);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(285, 26);
            this.txt_result.TabIndex = 1;
            this.txt_result.Text = "0";
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_calculer
            // 
            this.bt_calculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculer.Location = new System.Drawing.Point(392, 270);
            this.bt_calculer.Name = "bt_calculer";
            this.bt_calculer.Size = new System.Drawing.Size(102, 33);
            this.bt_calculer.TabIndex = 2;
            this.bt_calculer.Text = "Calculer";
            this.bt_calculer.UseVisualStyleBackColor = true;
            this.bt_calculer.Click += new System.EventHandler(this.bt_calculer_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quitter.Location = new System.Drawing.Point(392, 316);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(102, 33);
            this.bt_quitter.TabIndex = 2;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_multiplication);
            this.groupBox1.Controls.Add(this.rb_division);
            this.groupBox1.Controls.Add(this.rb_soustraction);
            this.groupBox1.Controls.Add(this.rb_addition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(66, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opération :";
            // 
            // rb_multiplication
            // 
            this.rb_multiplication.AutoSize = true;
            this.rb_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_multiplication.Location = new System.Drawing.Point(31, 92);
            this.rb_multiplication.Name = "rb_multiplication";
            this.rb_multiplication.Size = new System.Drawing.Size(107, 21);
            this.rb_multiplication.TabIndex = 3;
            this.rb_multiplication.TabStop = true;
            this.rb_multiplication.Text = "Multiplication";
            this.rb_multiplication.UseVisualStyleBackColor = true;
            // 
            // rb_division
            // 
            this.rb_division.AutoSize = true;
            this.rb_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_division.Location = new System.Drawing.Point(31, 128);
            this.rb_division.Name = "rb_division";
            this.rb_division.Size = new System.Drawing.Size(75, 21);
            this.rb_division.TabIndex = 2;
            this.rb_division.TabStop = true;
            this.rb_division.Text = "Division";
            this.rb_division.UseVisualStyleBackColor = true;
            // 
            // rb_soustraction
            // 
            this.rb_soustraction.AutoSize = true;
            this.rb_soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_soustraction.Location = new System.Drawing.Point(31, 58);
            this.rb_soustraction.Name = "rb_soustraction";
            this.rb_soustraction.Size = new System.Drawing.Size(105, 21);
            this.rb_soustraction.TabIndex = 1;
            this.rb_soustraction.TabStop = true;
            this.rb_soustraction.Text = "Soustraction";
            this.rb_soustraction.UseVisualStyleBackColor = true;
            // 
            // rb_addition
            // 
            this.rb_addition.AutoSize = true;
            this.rb_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_addition.Location = new System.Drawing.Point(31, 31);
            this.rb_addition.Name = "rb_addition";
            this.rb_addition.Size = new System.Drawing.Size(77, 21);
            this.rb_addition.TabIndex = 0;
            this.rb_addition.TabStop = true;
            this.rb_addition.Text = "Addition";
            this.rb_addition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_calculer);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button bt_calculer;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_multiplication;
        private System.Windows.Forms.RadioButton rb_division;
        private System.Windows.Forms.RadioButton rb_soustraction;
        private System.Windows.Forms.RadioButton rb_addition;
    }
}

