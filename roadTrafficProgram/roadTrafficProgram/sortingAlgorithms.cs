using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{

	public class sortingAlgorithms
	{
		public static int mergeCounter;
        public int[]? readSortingAlgorithms { get; set; }


		//BUBBLE SORT
		public int[] bubbleSort(int[] arrayOfIntegers) //asc
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
			Console.WriteLine("\n-------------------------");
			Console.WriteLine("Ascending bubble sort pass count is "+ passCount);
            Console.WriteLine("-------------------------");

            return arrayOfIntegers;

		}

		//REVERSE BUBBLE SORT
        public int[] reverseBubbleSort(int[] arrayOfIntegers) //should reverse sort
        { //desc
            int lengthOfList = arrayOfIntegers.Length;
            int passCount = 0;

            for (int i = 0; i < lengthOfList - 1; i++)
            {
                for (int j = 0; j < lengthOfList - i - 1; j++)
                {
                    if (arrayOfIntegers[j] < arrayOfIntegers[j + 1])
                    {
                        int temp = arrayOfIntegers[j];
                        arrayOfIntegers[j] = arrayOfIntegers[j + 1];
                        arrayOfIntegers[j + 1] = temp;
                        passCount = passCount + 1;

                    }
                }

            }
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Descending bubble sort pass count is " + passCount);
            Console.WriteLine("-------------------------");

            return arrayOfIntegers;

        }

		//INSERTION SORT
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
                    passCount = passCount + 1;
                }
				arrayOfIntegers[position] = currentValue;
				
			}
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Ascending insertion sort pass count is " + passCount);
            Console.WriteLine("-------------------------");
            return arrayOfIntegers;
		}

		//REVERSE INSERTION SORT
        public int[] reverseInsertionSort(int[] arrayOfIntegers)
        {
            int lengthOfList = arrayOfIntegers.Length;
            int passCount = 0;
            for (int i = 0; i < lengthOfList; i++)
            {
                int currentValue = arrayOfIntegers[i];
                int position = i;

                while (position > 0 && arrayOfIntegers[position - 1] < currentValue)
                {
                    arrayOfIntegers[position] = arrayOfIntegers[position - 1];
                    position = position - 1;
                    passCount = passCount + 1;
                }
                arrayOfIntegers[position] = currentValue;
                
            }
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Descending insertion sort pass count is " + passCount);
            Console.WriteLine("-------------------------");
            return arrayOfIntegers;
        }


		//MERGE ARRAYS FOR MERGE SORT
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

		//MAIN MERGE SORT
		public int[] mergeSort(int[] arrayOfIntegers, int left, int right)
		{
			if (left < right)
			{
				
				int middle = left + (right - left) / 2;
				mergeSort(arrayOfIntegers, left, middle);
				mergeSort(arrayOfIntegers, middle + 1, right);

				mergeArray(arrayOfIntegers, left, middle, right);
                mergeCounter++;
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ascending merge sort pass count is " + mergeCounter);
            Console.WriteLine("-------------------------");
            return arrayOfIntegers;
            
        }

		//QUICK SORT
		public int quickSortPartition(int[] arrayOfIntegers, int start, int end)
		{
			int pivot = arrayOfIntegers[start];
			int leftPointer = start + 1;
			int rightPointer = end;

			bool done = false;

			while (done == false)
			{
				while (leftPointer <= rightPointer && arrayOfIntegers[leftPointer] <= pivot)
				{
					leftPointer++;
				}
				while (arrayOfIntegers[rightPointer] >= pivot && rightPointer >= leftPointer)
				{
					rightPointer--;
				}

				if (rightPointer < leftPointer)
				{
					done = true;
				}
				else
				{
					int temp1 = arrayOfIntegers[leftPointer];
					arrayOfIntegers[leftPointer] = arrayOfIntegers[rightPointer];
					arrayOfIntegers[rightPointer] = temp1;
				}
			}

			int temp2 = arrayOfIntegers[start];
			arrayOfIntegers[start] = arrayOfIntegers[rightPointer];
			arrayOfIntegers[rightPointer] = temp2;
			return rightPointer;
		}

		public static int passCountQuickSort = 0;
        //MAIN QUICK SORT
        public int[] quickSort(int[] arrayOfIntegers, int start, int end)
		{

			if (start < end)
			{
				int split = quickSortPartition(arrayOfIntegers, start, end);
				quickSort(arrayOfIntegers, start, split - 1);
				quickSort(arrayOfIntegers, split + 1, end);
				passCountQuickSort++;
			}
            Console.WriteLine("-------------------------");
            Console.WriteLine("Quick sort pass count is " + passCountQuickSort);
            Console.WriteLine("-------------------------");
            return arrayOfIntegers;
		}
	}
}

