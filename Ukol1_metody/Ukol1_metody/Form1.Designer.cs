
namespace Ukol1_metody
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stranaa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Výpočet = new System.Windows.Forms.Button();
            this.stranab = new System.Windows.Forms.TextBox();
            this.stranac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vysledeklb = new System.Windows.Forms.Label();
            this.Obsahctverce = new System.Windows.Forms.RadioButton();
            this.obsahobdelnika = new System.Windows.Forms.RadioButton();
            this.objemkrychle = new System.Windows.Forms.RadioButton();
            this.objemkvadru = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // stranaa
            // 
            this.stranaa.Location = new System.Drawing.Point(75, 110);
            this.stranaa.Name = "stranaa";
            this.stranaa.Size = new System.Drawing.Size(100, 22);
            this.stranaa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // Výpočet
            // 
            this.Výpočet.Location = new System.Drawing.Point(695, 308);
            this.Výpočet.Name = "Výpočet";
            this.Výpočet.Size = new System.Drawing.Size(93, 42);
            this.Výpočet.TabIndex = 2;
            this.Výpočet.Text = "Vypocet";
            this.Výpočet.UseVisualStyleBackColor = true;
            this.Výpočet.Click += new System.EventHandler(this.Výpočet_Click);
            // 
            // stranab
            // 
            this.stranab.Location = new System.Drawing.Point(73, 144);
            this.stranab.Name = "stranab";
            this.stranab.Size = new System.Drawing.Size(100, 22);
            this.stranab.TabIndex = 7;
            // 
            // stranac
            // 
            this.stranac.Location = new System.Drawing.Point(73, 175);
            this.stranac.Name = "stranac";
            this.stranac.Size = new System.Drawing.Size(100, 22);
            this.stranac.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Výsledek:";
            // 
            // Vysledeklb
            // 
            this.Vysledeklb.AutoSize = true;
            this.Vysledeklb.Location = new System.Drawing.Point(125, 254);
            this.Vysledeklb.Name = "Vysledeklb";
            this.Vysledeklb.Size = new System.Drawing.Size(0, 17);
            this.Vysledeklb.TabIndex = 12;
            // 
            // Obsahctverce
            // 
            this.Obsahctverce.AutoSize = true;
            this.Obsahctverce.Location = new System.Drawing.Point(54, 22);
            this.Obsahctverce.Name = "Obsahctverce";
            this.Obsahctverce.Size = new System.Drawing.Size(121, 21);
            this.Obsahctverce.TabIndex = 13;
            this.Obsahctverce.TabStop = true;
            this.Obsahctverce.Text = "Obsah čtverce";
            this.Obsahctverce.UseVisualStyleBackColor = true;
            // 
            // obsahobdelnika
            // 
            this.obsahobdelnika.AutoSize = true;
            this.obsahobdelnika.Location = new System.Drawing.Point(231, 22);
            this.obsahobdelnika.Name = "obsahobdelnika";
            this.obsahobdelnika.Size = new System.Drawing.Size(139, 21);
            this.obsahobdelnika.TabIndex = 14;
            this.obsahobdelnika.TabStop = true;
            this.obsahobdelnika.Text = "Obsah Obdelníku";
            this.obsahobdelnika.UseVisualStyleBackColor = true;
            // 
            // objemkrychle
            // 
            this.objemkrychle.AutoSize = true;
            this.objemkrychle.Location = new System.Drawing.Point(417, 22);
            this.objemkrychle.Name = "objemkrychle";
            this.objemkrychle.Size = new System.Drawing.Size(119, 21);
            this.objemkrychle.TabIndex = 15;
            this.objemkrychle.TabStop = true;
            this.objemkrychle.Text = "Objem krychle";
            this.objemkrychle.UseVisualStyleBackColor = true;
            // 
            // objemkvadru
            // 
            this.objemkvadru.AutoSize = true;
            this.objemkvadru.Location = new System.Drawing.Point(592, 22);
            this.objemkvadru.Name = "objemkvadru";
            this.objemkvadru.Size = new System.Drawing.Size(117, 21);
            this.objemkvadru.TabIndex = 16;
            this.objemkvadru.TabStop = true;
            this.objemkvadru.Text = "Objem kvádru";
            this.objemkvadru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.objemkvadru);
            this.Controls.Add(this.objemkrychle);
            this.Controls.Add(this.obsahobdelnika);
            this.Controls.Add(this.Obsahctverce);
            this.Controls.Add(this.Vysledeklb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stranac);
            this.Controls.Add(this.stranab);
            this.Controls.Add(this.Výpočet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stranaa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Metody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stranaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Výpočet;
        private System.Windows.Forms.TextBox stranab;
        private System.Windows.Forms.TextBox stranac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Vysledeklb;
        private System.Windows.Forms.RadioButton Obsahctverce;
        private System.Windows.Forms.RadioButton obsahobdelnika;
        private System.Windows.Forms.RadioButton objemkrychle;
        private System.Windows.Forms.RadioButton objemkvadru;
    }
}

