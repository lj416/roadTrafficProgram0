using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{

	public class sortingAlgorithms
	{
        public int[]? readSortingAlgorithms { get; set; }

		public int[] bubbleSort(int[] arrayOfIntegers)
		{
            int lengthOfList = arrayOfIntegers.Length;
            int passCount = 0;

			for (int i = 0; i < lengthOfList - 1; i++)
			{
				for (int j = 0; j < lengthOfList - i - 1; j++)
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

		public void mergeArray(int[] arrayOfIntegers, int left, int middle, int right)
		{
			int lengthLeftArray = middle - left + 1;
			int lengthRightArray = right - middle;

			int i;
			int j;

            var leftTempArray = new int[lengthLeftArray];
            var rightTempArray = new int[lengthRightArray];

			for (i = 0; i < lengthLeftArray; i++)
			{
				leftTempArray[i] = arrayOfIntegers[left + i];
			}

			for (j = 0; j < lengthRightArray; j++)
			{
				rightTempArray[j] = arrayOfIntegers[middle + 1 + j];
			}

			i = 0;
			j = 0;

			int k = left;

			while (i < lengthLeftArray && j < lengthRightArray)
			{
				if (leftTempArray[i] <= rightTempArray[j])
				{
					arrayOfIntegers[k++] = leftTempArray[i++];
				}
				else
				{
					arrayOfIntegers[k++] = rightTempArray[j++];
				}
			}

			while (i < lengthLeftArray)
			{
				arrayOfIntegers[k++] = leftTempArray[i++];
			}

			while (j < lengthRightArray)
			{
				arrayOfIntegers[k++] = rightTempArray[j++];
			}

        }


		public int[] mergeSort(int[] arrayOfIntegers, int left, int right)
		{
			if (left < right)
			{
				int middle = left + (right - left) / 2;
				mergeSort(arrayOfIntegers, left, middle);
				mergeSort(arrayOfIntegers, middle + 1, right);

				mergeArray(arrayOfIntegers, left, middle, right);

			}
			return arrayOfIntegers;
            
        }

	}
}

