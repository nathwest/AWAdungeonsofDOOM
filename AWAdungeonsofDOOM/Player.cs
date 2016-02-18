using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWAdungeonsofDOOM
{
    class Player
    {
        public Player(string name, int health, int attackStrength, int liftStrength)
        {
            Name = name;
            Health = health;
            Attackstrength = attackStrength;
            BackPack = new List<Item>();
            LiftStrength = liftStrength;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackstrength { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Item> BackPack { get; set; }
        public int LiftStrength { get; set; }

    }
}
