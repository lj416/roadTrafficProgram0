using System;
namespace roadTrafficProgram
{
	public class searchingAlgorithms
	{

		public void linearSearch(int[] arrayOfIntegers, int itemSought)
		{
			bool itemFound = false; //flag to indicate whether found
			for (int i = 0; i < arrayOfIntegers.Length; i++)
			{
				if (arrayOfIntegers[i] == itemSought)
				{
					Console.WriteLine(itemSought+" is found at "+i);
					itemFound = true;
				}
			}

			if (itemFound == false)
			{
				Console.WriteLine("Item wasn't found.");
				//output nearest values
			}
		}

		public int binarySearch(int[] aList, int itemSought)
		{
			bool found = false;
			int index = -1;
			int first = 0;
			int last = aList.Length - 1;

			while (first <= last && found == false)
			{
				int midpoint = ((first + last) / 2);

				if (aList[midpoint] == itemSought)
				{
					found = true;
					index = midpoint;
				}
				else
				{
					if (aList[midpoint] < itemSought)
					{
						first = midpoint + 1;
					}
					else
					{
						last = midpoint - 1;
					}
				}
			}
			Console.WriteLine("The item is found at position: "+index);
			return index;
		}

	}
}

