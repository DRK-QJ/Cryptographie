
namespace Jouniaux_Cryptographie
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CrypDot = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_cryptPerso = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_DecryptPerso = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_CrypDot
            // 
            this.btn_CrypDot.Location = new System.Drawing.Point(13, 117);
            this.btn_CrypDot.Name = "btn_CrypDot";
            this.btn_CrypDot.Size = new System.Drawing.Size(336, 36);
            this.btn_CrypDot.TabIndex = 1;
            this.btn_CrypDot.Text = "cryptage .Net";
            this.btn_CrypDot.UseVisualStyleBackColor = true;
            this.btn_CrypDot.Click += new System.EventHandler(this.btn_CrypDot_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "décryptage .Net";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(366, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(413, 20);
            this.textBox4.TabIndex = 5;
            // 
            // btn_cryptPerso
            // 
            this.btn_cryptPerso.Location = new System.Drawing.Point(366, 151);
            this.btn_cryptPerso.Name = "btn_cryptPerso";
            this.btn_cryptPerso.Size = new System.Drawing.Size(413, 34);
            this.btn_cryptPerso.TabIndex = 6;
            this.btn_cryptPerso.Text = "Cryptage Vigenere";
            this.btn_cryptPerso.UseVisualStyleBackColor = true;
            this.btn_cryptPerso.Click += new System.EventHandler(this.btn_cryptPerso_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(366, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(367, 191);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(411, 20);
            this.textBox6.TabIndex = 8;
            // 
            // btn_DecryptPerso
            // 
            this.btn_DecryptPerso.Location = new System.Drawing.Point(368, 219);
            this.btn_DecryptPerso.Name = "btn_DecryptPerso";
            this.btn_DecryptPerso.Size = new System.Drawing.Size(410, 32);
            this.btn_DecryptPerso.TabIndex = 9;
            this.btn_DecryptPerso.Text = "Décryptage Vigenere";
            this.btn_DecryptPerso.UseVisualStyleBackColor = true;
            this.btn_DecryptPerso.Click += new System.EventHandler(this.btn_DecryptPerso_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(368, 257);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(410, 20);
            this.textBox7.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 422);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btn_DecryptPerso);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_cryptPerso);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_CrypDot);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CrypDot;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_cryptPerso;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_DecryptPerso;
        private System.Windows.Forms.TextBox textBox7;
    }
}

