using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Program
{
    class Program
    {
        static Random randomness = new Random();
        static int playerHP = randomness.Next(10, 200);


        static void Main(string[] args)
        {
            Console.Title = "TextFeud";
            Console.SetWindowSize(34,14);

            enemy.Setup();
            

            string userInput;


            // Game Loop
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.Clear();

                DisplayStats();
               


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write ("\n1: Attack Enemy \n2: Heal\n\nUser Input:");
                userInput = Console.ReadLine();


                //User Choice
                if (userInput == "1") //attack
                {
                    Attack();
                }
                else if (userInput == "2") //heal
                {
                    Heal();
                }
                else
                {
                    continue;
                }

                EnemyTurn();

                Console.ReadKey();
                //End of While-loop
            }
            if (enemy.hp > 1)
            {
                Console.WriteLine("Sorry, your dead...");
            }
            else
            {
                Console.WriteLine("\nCongratulations! You won!");
            }
            Console.Read();
        }



        static void DisplayStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer Health: " + playerHP);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enemy Health: " + enem.hp);
        }

        static void Attack()
        {
            int playerDmg = randomness.Next(10, 16);
            enemy.hp -= playerDmg; //subtracts player damage from enemyhp
            Console.WriteLine("Player attacked for " + playerDmg);
        }

        static void Heal()
        {
            int healAmount = randomness.Next(12, 15);
            playerHP += healAmount;
            Console.WriteLine("Player healed for " + healAmount);
        }

        static void EnemyTurn()
        {
            if(randomness.Next(10-1) >= 3)
            {
                //Enemy Attacks
                playerHP -= enemy.dmg;
                Console.WriteLine("Enemy attacked for " + enemyDmg);
            }
            else
            {
                int healAmount = randomness.Next(12, 15);
                enemy.hp += healAmount;
                Console.WriteLine("Enemy healed for " + healAmount);
            }

        }

    }
}
