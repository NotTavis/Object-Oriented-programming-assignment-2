using System;
namespace OOP_Assignment_2
{
	public class Statistics
	{
		private int highScore = 0;
		public void AddHighScore(int score)
		{
			if (score > highScore)
			{
				highScore = score;
			}
		}

		public void DisplayHighScore()
		{
			Console.WriteLine("\nHigh Score: " + highScore);
		}
	}
}

