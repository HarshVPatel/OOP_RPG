using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {

        List<Monster> Monsters { get; set; }
        public Game Game { get; set; }
        public Hero Hero { get; set; }
        public Monster Enemy { get; set; }
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.Hero = hero;
            this.Game = game;
            this.AddMonster("Squid", 15, 8, 20);
            this.AddMonster("Shark", 12, 6, 25);
            this.AddMonster("Zebra", 13, 7, 19);
            this.AddMonster("Hao", 12, 6, 18);




            


        }


        public void AddMonster(string name, int strength, int defense, int hp) {
            var monster = new Monster(name, strength, defense, hp);
           
            this.Monsters.Add(monster);
        }
        
        public void Start() {
            var RandomMonster = Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
            var FirstMonster = this.Monsters.First();
            var SecondMonster = this.Monsters[1];
            var LastMonster = this.Monsters.Last();
            Random random = new Random();
            int randomNumber = random.Next(4);

            this.Enemy = this.Monsters[randomNumber];

            var firstmonsterwithlessthan20HP = this.Monsters.Where(monster => monster.OriginalHP < 20).First();

            var firstMonsterwith11strength = this.Monsters.Where(monster => monster.Strength >= 11).First();
            var enemy = RandomMonster;
            Console.WriteLine("You've encountered a " + enemy.Name + "! " + enemy.Strength + " Strength/" + enemy.Defense + " Defense/" + 
            enemy.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn(enemy);
            }
            else { 
                this.Game.Main();
            }
        }
        
        public void HeroTurn(Monster monster){
           var enemy = monster;
           var compare = Hero.Strength - enemy.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
               enemy.CurrentHP -= damage;
           }
           else{
               damage = compare;
               enemy.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(enemy.CurrentHP <= 0){
               this.Win(enemy);
           }
           else
           {
               this.MonsterTurn(enemy);
           }
           
        }
        
        public void MonsterTurn(Monster monster){
           var enemy = monster;
           int damage;
           var compare = enemy.Strength - Hero.Defense;
           if(compare <= 0) {
               damage = 1;
               Hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               Hero.CurrentHP -= damage;
           }
           Console.WriteLine(enemy.Name + " does " + damage + " damage!");
           if(Hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win(Monster monster) {
            var enemy = monster;
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
            Hero.Gold = Hero.Gold + monster.Gold;
            Game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}