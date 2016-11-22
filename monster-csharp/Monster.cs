﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster_csharp
{
    class Monster
    {
        public string name;
        public string hp;
        public string damage;

        public Monster(string name, string hp, string damage)
        {
            this.name   = name;
            this.hp     = hp;
            this.damage = damage;
            describe();
        }

        public void describe()
        {
            Console.WriteLine("Questo è " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("DAMAGE: " + damage);
        }
    }
}
