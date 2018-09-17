using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{

    class Potion : Item
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }

        public Potion(int Hp, string name, int OriginalValue, int ResellValue)
        {
            this.HP = Hp;
            this.Name = name;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }

        public Potion(string name, int Hp, int originalValue, int resellValue)
        {
            Name = name;
            HP = Hp;
            OriginalValue = originalValue;
            ResellValue = resellValue;
        }
    }
}
