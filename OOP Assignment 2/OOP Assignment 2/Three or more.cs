using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
	internal class Three_or_more
	{
		public int player1Points;
		public int player2Points;

		public Three_or_more()
		{
			player1Points = 0;
			player2Points = 0;
		}

        public void StartThreeOrMore()
		{
			Die die = new Die();
			int[] rolls = new int[5];
			bool player1Turn = true;

			while (player1Points < 20 && player2Points < 20)
			{
                if (player1Turn == true)
                {
                    Console.WriteLine("\nPlayer 1's turn:");
                }
                else
                {
                    Console.WriteLine("\nPlayer 2's turn:");
                }
                for (int i = 0; i < 5; i++)
				{
					die.diceRoll();
					rolls[i] = die.rollValue;
				}

				var groups = rolls.GroupBy(x => x);
				int totalPoints = 0;
				bool canReRoll = true;

				foreach (var group in groups)
				{
					Console.WriteLine("you rolled " + group.Count() + " " + group.Key + "s");
					int count = group.Count();
					int points = 0;
					if (count == 2 && canReRoll)
					{
						int playerChoice;
						Console.WriteLine("You got 2 of a kind, you can either reroll the remaining 3 dice or you can reroll all 5");
						while (!int.TryParse(Console.ReadLine(), out playerChoice) || (playerChoice != 3 && playerChoice != 5))
						{
							Console.WriteLine("Invalid Input. Please enter either 3 or 5: ");
						}
						if (playerChoice == 3)
						{
							for (int i = 0; i < 5; i++)
							{
								if (rolls[i] != group.Key)
								{
									die.diceRoll();
									rolls[i] = die.rollValue;
								}
							}
						}
						else if (playerChoice == 5)
						{
							for (int i = 0; i < 5; i++)
							{
								die.diceRoll();
								rolls[i] = die.rollValue;
							}
						}
						canReRoll = false;

					}
					else if (count >= 3)
					{
						if (count == 3)
						{
							points = 3;
						}
						else if (count == 4)
						{
							points = 6;
						}
						else if (count == 5)
						{
							points = 12;
						}
						totalPoints += points;
					}
                }
					


				if (player1Turn)
				{
					player1Points += totalPoints;
					Console.WriteLine("Player 1 has " + player1Points + " Points.");
				}
				else
				{
					player2Points += totalPoints;
					Console.WriteLine("Player 2 has " + player2Points + "points");
				}
				player1Turn = !player1Turn;
			}
			if (player1Points >= 20 )
			{
				Console.WriteLine("Player 1 wins!");
			}
			else if (player2Points >= 20)
			{
				Console.WriteLine("Player 2 wins!");
			}
		}
	}
}

