using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWAdungeonsofDOOM
{
    class Monster
    {
        public Monster(string name, int health, int attackstrength)
        {
            Name = name;
            Health = health;
            Attackstrength = attackstrength;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackstrength { get; set; }

    }
}
