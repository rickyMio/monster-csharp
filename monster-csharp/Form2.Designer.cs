namespace monster_csharp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.riepilogoMostro1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.riepilogoMostro2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riepilogo mostri";
            // 
            // riepilogoMostro1
            // 
            this.riepilogoMostro1.Location = new System.Drawing.Point(39, 76);
            this.riepilogoMostro1.Multiline = true;
            this.riepilogoMostro1.Name = "riepilogoMostro1";
            this.riepilogoMostro1.ReadOnly = true;
            this.riepilogoMostro1.Size = new System.Drawing.Size(338, 78);
            this.riepilogoMostro1.TabIndex = 1;
            this.riepilogoMostro1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOSTRO 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MOSTRO 2";
            // 
            // riepilogoMostro2
            // 
            this.riepilogoMostro2.Location = new System.Drawing.Point(39, 207);
            this.riepilogoMostro2.Multiline = true;
            this.riepilogoMostro2.Name = "riepilogoMostro2";
            this.riepilogoMostro2.ReadOnly = true;
            this.riepilogoMostro2.Size = new System.Drawing.Size(338, 78);
            this.riepilogoMostro2.TabIndex = 4;
            this.riepilogoMostro2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 338);
            this.Controls.Add(this.riepilogoMostro2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.riepilogoMostro1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox riepilogoMostro1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox riepilogoMostro2;
    }
}