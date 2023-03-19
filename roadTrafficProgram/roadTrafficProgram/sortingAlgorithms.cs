using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{
	public class sortingAlgorithms
	{
		public sortingAlgorithms()
		{
		}

		public int[] bubbleSort(int[] arrayOfIntegers)
		{
			int n = arrayOfIntegers.Length;

			for (int i = 0; i < n-1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arrayOfIntegers[j] < arrayOfIntegers[j + 1])
					{
						int temp = arrayOfIntegers[j];
						arrayOfIntegers[j] = arrayOfIntegers[j + 1];
						arrayOfIntegers[j + 1] = temp;
					}
				}

			}

			return arrayOfIntegers;

		}
	}
}

