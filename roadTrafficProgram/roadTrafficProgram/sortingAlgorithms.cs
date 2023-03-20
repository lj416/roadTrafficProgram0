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

		public int[] mergeSort(int[] arrayOfIntegers)
		{
            int lengthOfList = arrayOfIntegers.Length;
            int mid = lengthOfList / 2;
			int i = 0;
			int[] leftHalf = { };
			int[] rightHalf = { };
			/*
			while (i < mid)
			{

                leftHalf.Append(arrayOfIntegers[i]);
				i++;
            }

			while (mid < lengthOfList)
			{
				rightHalf.Append(arrayOfIntegers[mid]);
				mid++;
			}
			*/

            if (lengthOfList > 1)
			{
                while (i < mid)
                {

                    leftHalf.Append(arrayOfIntegers[i]);
                    i++;
                }

                while (mid < lengthOfList)
                {
                    rightHalf.Append(arrayOfIntegers[mid]);
                    mid++;
                }

				i = 0;
				int j = 0;
				int k = 0;

				while (i < leftHalf.Length && j < rightHalf.Length)
				{
					if (leftHalf[i] < rightHalf[j])
					{
						arrayOfIntegers[k] = leftHalf[i];
						i++;
					}
					else
					{
						arrayOfIntegers[k] = leftHalf[i];
						j++;
					}
					k++;
				}
				while (i < leftHalf.Length)
				{
					arrayOfIntegers[k] = leftHalf[i];
					i++;
					k++;
				}
				while (j < rightHalf.Length)
				{
					arrayOfIntegers[k] = rightHalf[j];
					j++;
					k++;
				}

            }

			return arrayOfIntegers;
        }

	}
}

