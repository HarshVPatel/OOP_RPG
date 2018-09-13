using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        public List<Weapon> Weaposn { get; set; }
        public List<Potion> Potions{ get; set; }
        public List<Armor> Armor { get; set; }

        public Shop()
        {
            var Weapon = new List<string>();
            var Potion = new List<string>();
            var Armor = new List<string>();

        }
    }
}
