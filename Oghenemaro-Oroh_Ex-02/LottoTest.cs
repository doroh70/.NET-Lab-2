using System;
namespace Oghenemaro_Oroh_Ex_02
{
	public class LottoTest
	{
		public LottoTest()
		{
		}
		public static void Main()
        {
			Console.WriteLine("Welcome to Lotto game");
			Console.WriteLine();
			//5 turns guessing before computer wins
			for (int i = 0; i <5; i++)
            {
				Lotto test = new Lotto();
				Console.WriteLine("Make your guess");
				Console.Write("Enter Number from 3 to 27: ");
				int guess = Int32.Parse(Console.ReadLine());
				if (guess == test.sumOfArray())
                {
					Console.WriteLine("Congratulations!! You've won the lotto!");
					break;
                }
				if(i == 4)
                {
					Console.WriteLine("Computer Wins!");

				}
            }
        }
	}
}

