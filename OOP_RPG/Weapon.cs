using System;
namespace OOP_RPG
{
    public class Weapon: Item
    {
        private string v1;
        private int v2;

        public Weapon(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Weapon(string name, int strength, int OriginalValue, int ResellValue) {
            this.Name = name;
            this.Strength = strength;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
    }
}