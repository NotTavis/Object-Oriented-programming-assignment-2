using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1.Play sevens out");
                Console.WriteLine("2.Play Three or more");
                Console.WriteLine("3.Test");
                Console.WriteLine("4.Quit");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input, please choose a number from 1 to 4:");
                }
                if (choice == 1)
                {
                    Sevens_Out game = new Sevens_Out();
                    int total1 = game.StartSevensOut();
                    int player1total = total1;
                    Console.WriteLine("Player 1 turn over, total was " + total1);
                    Console.WriteLine("Now its player 2's go");
                    Sevens_Out game2 = new Sevens_Out();
                    int total2 = game2.StartSevensOut();
                    int player2total = total2;
                    Console.WriteLine("player 2 got " + total2);
                    if (total1 > total2)
                    {
                        Console.WriteLine("Player 1 Wins");
                    }
                    else if (total2 > total1)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("its a draw");
                    }
                }
                else if (choice == 2)
                {
                    Three_or_more gameof3 = new Three_or_more();
                    gameof3.StartThreeOrMore();
                }
                else if (choice == 3)
                {
                    Tests.RunTests();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for play!");
                    quit = true;
                }
                Console.WriteLine("Press any key to see the menu");
                Console.ReadKey();


            }
        }
        
    }
}
    


