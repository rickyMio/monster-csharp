using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monster_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {
            Monster m1 = new Monster(name1Txt.Text, hp1Txt.Text, damage1Txt.Text);
            Monster m2 = new Monster(name2Txt.Text, hp2Txt.Text, damage2Txt.Text);

            Form2 riepilogoMostri = new Form2();
            this.Visible = false;
            riepilogoMostri.ShowDialog();
            
           

        }
    }
}
