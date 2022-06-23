using System;
namespace Oghenemaro_Oroh_Ex_02
{
	public class Lotto
	{
		//instance variables array
		int[] array = new int[3];

		//constructor that takes 0 parameters
		public Lotto()
		{
			//Using random class, to generate random numbers to populate array
			Random rd = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rd.Next(1, 10);
			}
		}

		//Method to return array
		public int[] returnArray()
        {
			return array;
        }

		public int sumOfArray()
        {
			return array.Sum();
        }
	}
}