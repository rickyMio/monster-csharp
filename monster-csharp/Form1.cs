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
        private List<Monster> monsters = new List<Monster>();

        public Form1()
        {
            InitializeComponent();
            Deserializer.deserialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            addMonster(new Monster("tizio", 200, 100));
            Console.WriteLine(monsters[0].describe());
        }
=======
            Monster m1 = new Monster(name1Txt.Text, hp1Txt.Text, damage1Txt.Text);
            Monster m2 = new Monster(name2Txt.Text, hp2Txt.Text, damage2Txt.Text);

            Form2 riepilogoMostri = new Form2();
            this.Visible = false;
            riepilogoMostri.ShowDialog();
            
           
>>>>>>> a16903a26147f3420febebafbecaca5fdaeeab2c

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }
    }
}
