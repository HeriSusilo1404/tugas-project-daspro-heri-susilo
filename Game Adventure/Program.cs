using System;

namespace GameAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Aventure Game");
            Console.WriteLine("What Is Your Name?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine($"Hi "+player.Name+", Ready To Begin The Game?[y/n]");
            string Ready = Console.ReadLine();
            if(Ready=="y")
            {
                Console.WriteLine(player.Name+" is enter is entering the word...");
                Enemy enemy1 = new Enemy("Butterfly");
                Console.WriteLine(player.Name+" is encountring "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" attacking you.....");
                Console.WriteLine("Chosee Your action");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction)
                    {
                        case "1":
                        Console.WriteLine($"{player.Name} is doing Single Attack");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"Player Health : {player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        
                        case "2":
                        player.Swing();
                        player.Experience += 0.9f;
                        enemy1.GetHit(player.AttackPower);
                        Console.WriteLine($"Player Health : {player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;

                        case "3":
                        player.Rest();
                        Console.WriteLine("Energy is being restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        break;

                        case "4":
                        Console.WriteLine($"{player.Name} is running away");
                        break;
                    }
                }
                Console.WriteLine($"{player.Name} get {player.Experience} experience point");
            }
            else
            {
                Console.WriteLine("Good Bye...");
                Console.ReadLine();
            }
        }
    }
    class Novice
    {
        public int Health { get; set;}
        public string Name { get; set;}
        public int AttackPower { get; set;}
        public int SkillSlot { get; set;}
        public bool IsDead { get; set;}
        public float Experience{ get; set;}
        Random rnd = new Random();

        public Novice (){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing(){
            if(SkillSlot >0){
                Console.WriteLine("SWING !!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }else{
                Console.WriteLine("You don't have energy");
            }
        }
        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by" +hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }
        
        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine("You are Dead, GAME OVER");
            IsDead = true;
        }
    }
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(1,20);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" Get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name+" is Dead");
            IsDead = true;
        }
    }
}
    