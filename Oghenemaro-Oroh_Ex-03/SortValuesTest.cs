using System;
namespace Oghenemaro_Oroh_Ex_03
{
	public class SortValuesTest
	{
		public SortValuesTest()
		{
		}
		public static void Main()
        {
			
            int[] array = SortValues.Sortnumbers(1, 2, 3);

			for(int i = 0; i<array.Length; i++)
            {
				Console.Write(array[i]);
            }
        }
	}
}

