using System;
namespace OOP_RPG
{
    public class Armor
    {
        public Armor(string name, int defense, int originalValue, int resellValue)
        {
            this.Name = name;
            this.Defense = defense;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;
        }
        
        public string Name { get; set; }
        public int Defense { get; set; }
        int OriginalValue { get; set; }
        int ResellValue { get; set; }
    }
}