namespace monster_csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name1Txt = new System.Windows.Forms.TextBox();
            this.name2Txt = new System.Windows.Forms.TextBox();
            this.hp1Txt = new System.Windows.Forms.TextBox();
            this.hp2Txt = new System.Windows.Forms.TextBox();
            this.damage1Txt = new System.Windows.Forms.TextBox();
            this.damage2Txt = new System.Windows.Forms.TextBox();
            this.buttonConferma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOSTRO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOSTRO 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Danno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Danno";
            // 
            // name1Txt
            // 
            this.name1Txt.Location = new System.Drawing.Point(85, 82);
            this.name1Txt.Name = "name1Txt";
            this.name1Txt.Size = new System.Drawing.Size(196, 20);
            this.name1Txt.TabIndex = 8;
            // 
            // name2Txt
            // 
            this.name2Txt.Location = new System.Drawing.Point(403, 82);
            this.name2Txt.Name = "name2Txt";
            this.name2Txt.Size = new System.Drawing.Size(196, 20);
            this.name2Txt.TabIndex = 9;
            // 
            // hp1Txt
            // 
            this.hp1Txt.Location = new System.Drawing.Point(85, 133);
            this.hp1Txt.Name = "hp1Txt";
            this.hp1Txt.Size = new System.Drawing.Size(196, 20);
            this.hp1Txt.TabIndex = 10;
            // 
            // hp2Txt
            // 
            this.hp2Txt.Location = new System.Drawing.Point(403, 133);
            this.hp2Txt.Name = "hp2Txt";
            this.hp2Txt.Size = new System.Drawing.Size(196, 20);
            this.hp2Txt.TabIndex = 11;
            // 
            // damage1Txt
            // 
            this.damage1Txt.Location = new System.Drawing.Point(85, 186);
            this.damage1Txt.Name = "damage1Txt";
            this.damage1Txt.Size = new System.Drawing.Size(196, 20);
            this.damage1Txt.TabIndex = 12;
            // 
            // damage2Txt
            // 
            this.damage2Txt.Location = new System.Drawing.Point(403, 186);
            this.damage2Txt.Name = "damage2Txt";
            this.damage2Txt.Size = new System.Drawing.Size(196, 20);
            this.damage2Txt.TabIndex = 13;
            // 
            // buttonConferma
            // 
            this.buttonConferma.Location = new System.Drawing.Point(272, 266);
            this.buttonConferma.Name = "buttonConferma";
            this.buttonConferma.Size = new System.Drawing.Size(89, 35);
            this.buttonConferma.TabIndex = 14;
            this.buttonConferma.Text = "CONFERMA";
            this.buttonConferma.UseVisualStyleBackColor = true;
            this.buttonConferma.Click += new System.EventHandler(this.buttonConferma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 349);
            this.Controls.Add(this.buttonConferma);
            this.Controls.Add(this.damage2Txt);
            this.Controls.Add(this.damage1Txt);
            this.Controls.Add(this.hp2Txt);
            this.Controls.Add(this.hp1Txt);
            this.Controls.Add(this.name2Txt);
            this.Controls.Add(this.name1Txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name1Txt;
        private System.Windows.Forms.TextBox name2Txt;
        private System.Windows.Forms.TextBox hp1Txt;
        private System.Windows.Forms.TextBox hp2Txt;
        private System.Windows.Forms.TextBox damage1Txt;
        private System.Windows.Forms.TextBox damage2Txt;
        private System.Windows.Forms.Button buttonConferma;
    }
}

