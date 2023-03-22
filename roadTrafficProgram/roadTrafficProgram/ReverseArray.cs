using System;
using System.Linq;

namespace roadTrafficProgram
{
	public class ReverseArray
	{
		public static int[] reverseTheArray(int[] arrayOfIntegers)
		{
			/*
			int[] newArrayOfIntegers = Array.Empty<int>(); //initialises an empty array
			int j = 0;

			int lengthOfArray = arrayOfIntegers.Length - 1;

			for (int i = lengthOfArray; i >= 0; i--)
			{
				newArrayOfIntegers[j] = arrayOfIntegers[i];
				j++;
			}

			return newArrayOfIntegers;
			*/

			int[] reversedArray = Array.Empty<int>();
			int leftPointer = 0;
			//int rightPointer = arrayOfIntegers.Length - 1;

			for (int rightPointer = arrayOfIntegers.Length - 1; rightPointer >= 0; rightPointer--)
			{
				Console.WriteLine("RIGHT POINTER "+rightPointer);
                reversedArray.Append(arrayOfIntegers[rightPointer]);
			}

			return reversedArray;
		}
	}
}

