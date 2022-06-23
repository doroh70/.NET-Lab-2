using System;
namespace Oghenemaro_Oroh_Ex_03
{
	public class SortValues
	{
		/*
		 * Reverse sort
		 */

		public SortValues()
		{
		}

		public static int[] Sortnumbers(params int[] array)
        {
			Array.Reverse(array);
			return array;
        }
	}
}

