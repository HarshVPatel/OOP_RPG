using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        public List<Weapon> Weapons { get; set; }
        public List<Potion> Potions{ get; set; }
        public List<Armor> Armors { get; set; }
        public List<Game>Game { get; set; }
        public List<Armor> ArmorsBag { get; set; }
        public List<Weapon> WeaponsBag { get; set; }
        public List<Potion> PotionsBag { get; set; }



        public Shop(Game game)
        {
            this.Weapons = new List<Weapon>();
            this.Potions = new List<Potion>();
            this.Armors = new List<Armor>();
            this.AddWeapon("Sword", 10, 2, 3);
            this.AddWeapon("Axe", 12, 3, 4);
            this.AddWeapon("LongSword", 20, 5, 7);
            this.AddArmor("Wooden Armor", 10, 2, 3);
            this.AddArmor("Metal Armor", 20, 5, 7);
            this.AddPotions("Healing Potion", 5, 5, 5);
        }



        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public int itemNumber { get; set; }

        public void AddWeapon(string name, int originalValue, int resellValue, int strength)
        {
            var weapon = new Weapon(name, originalValue, resellValue, strength);

            this.Weapons.Add(weapon);

        }

        public void AddPotions(string name, int originalValue, int resellValue, int hp)
        {
            var potion = new Potion(name, hp, originalValue, resellValue);

            this.Potions.Add(potion);
        }

        public void AddArmor(string name, int originalValue, int resellValue, int defense)
        {
            var armor = new Armor(name, originalValue, resellValue, defense);

            this.Armors.Add(armor);

        }

        

        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1. Buy Item");
            Console.WriteLine("2. Sell Item");
            Console.WriteLine("3. Return to Game Menu");

            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyfromUser();
            }
            else if (input == "3")
            {
                this.Menu();
            }
            else
            {
                return;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armors");
            Console.WriteLine("3. Potions");
            Console.WriteLine("4. Return to main menu");
            var selectedItem = Console.ReadLine();
            if (selectedItem == "1")
            {
                foreach (var weapon in this.Weapons)
                {
                    Console.WriteLine(this.Weapons.IndexOf(weapon) + ") " + weapon.Name + " costs " + weapon.OriginalValue + " Gold");

                }

                Console.WriteLine("4. Return to main menu");
                var choosenWeapon = Console.ReadLine();
                if (choosenWeapon == "0" || choosenWeapon == "1" || choosenWeapon == "2")
                {
                    this.Sell(Convert.ToInt32(choosenWeapon), "weapon");
                    Console.ReadLine();
                    this.Menu();

                }
                else
                {
                    this.Menu();
                }
            }
            if (selectedItem == "2")
            {
                foreach (var armor in this.Armors)
                {

                    Console.WriteLine(this.Armors.IndexOf(armor) + ") " + armor.Name + " costs " + this.OriginalValue + " Gold");

                }
                var chooseArmor = Console.ReadLine();
                if (chooseArmor == "0" || chooseArmor == "1" || chooseArmor == "2")
                {
                    this.Sell(Convert.ToInt32(chooseArmor), "Armor");
                    Console.ReadLine();
                    this.Menu();

                }
                else
                {
                    this.Menu();
                }
            }
            if (selectedItem == "3")
            {
                foreach (var p in this.Potions)
                {
                    Console.WriteLine(this.Potions.IndexOf(p) + ". " + p.Name + " costs " + p.OriginalValue + " Gold");

                }
                var choosePotion = Console.ReadLine();
                if (choosePotion == "0" || choosePotion == "1" || choosePotion == "2")
                {
                    this.Sell(Convert.ToInt32(choosePotion), "potion");
                    Console.ReadLine();
                    this.Menu();
                }
                else
                {
                    this.Menu();
                }
            }
            else if (selectedItem == "4" || selectedItem == "return")
            {
                this.Menu();
                Console.ReadLine();


            }
        }


      

        public void BuyfromUser()
        {
            Console.WriteLine("*****" + this.Name + "*****");
            Console.WriteLine("Re-sell Value: " + this.ResellValue);
            var input = Console.ReadLine();
            if (input == "itemNumber")
            {
                this.BuyfromUser();
            }
            else if (input == "return")
            {
                this.Menu();
            }
            else
            {
                return;
            }
        }

        public void SellfromUser()
        {
            Console.WriteLine("Buy items here.");
        }

        public void Sell(int v, string v1)
        {
            Console.WriteLine("Sell your items here.");
        }

    }
}

    

