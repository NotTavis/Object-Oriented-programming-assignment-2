using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
	internal class Sevens_Out
	{
		int turnTotal = 0;
		int total = 0;
		bool gameOver = false;
        Die die = new Die();
        public int StartSevensOut()
		{
			while (!gameOver)
			{
				die.diceRoll();
				int rollValue1 = die.rollValue;
				die.diceRoll();
				int rollValue2 = die.rollValue;
				turnTotal = rollValue1 + rollValue2;
                Console.WriteLine("\nYou rolled a " + rollValue1 + " and a " + rollValue2);
				if (rollValue1 == rollValue2)
				{
					turnTotal = turnTotal * 2;
					Console.WriteLine("Double points!");
				}
				Console.WriteLine("The sum of these is " + turnTotal);
				
				if (turnTotal == 7)
				{
					gameOver = true;
					Console.WriteLine("You rolled a 7!");
				}
				else
				{
					total += turnTotal;
					Console.WriteLine("Your total is now " + total);
				}

			}
            
			return total;
        }















	}
}

