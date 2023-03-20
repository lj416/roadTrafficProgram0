using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{

	public class sortingAlgorithms
	{
        //public static List<ReadTextFiles> Road_1_256_textfile = new List<ReadTextFiles>();
        //public static List<ReadTextFiles> Road_2_256_textfile = new List<ReadTextFiles>();
        //public static List<ReadTextFiles> Road_3_256_textfile = new List<ReadTextFiles>();

        public int[]? readSortingAlgorithms { get; set; }

		public int[] bubbleSort(int[] arrayOfIntegers)
		{
			int n = arrayOfIntegers.Length;
			int passCount = 0;

			for (int i = 0; i < n-1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arrayOfIntegers[j] > arrayOfIntegers[j + 1])
					{
                        int temp = arrayOfIntegers[j];
						arrayOfIntegers[j] = arrayOfIntegers[j + 1];
						arrayOfIntegers[j + 1] = temp;
						passCount = passCount + 1;

					}
				}

			}
			Console.WriteLine("-------------------------");
			Console.WriteLine("Pass count is "+ passCount);
            Console.WriteLine("-------------------------");

            return arrayOfIntegers;

		}

		public int[] insertionSort(int[] arrayOfIntegers)
		{
			int lengthOfList = arrayOfIntegers.Length;
			int passCount = 0;
			for (int i = 0; i < lengthOfList; i++)
			{
				int currentValue = arrayOfIntegers[i];
				int position = i;

				while (position > 0 && arrayOfIntegers[position - 1] > currentValue)
				{
					arrayOfIntegers[position] = arrayOfIntegers[position - 1];
					position = position - 1;
				}
				arrayOfIntegers[position] = currentValue;
				passCount = passCount + 1;
			}
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pass count is " + passCount);
            Console.WriteLine("-------------------------");
            return arrayOfIntegers;
		}

	}
}

