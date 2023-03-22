using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{
	public class ReadTextFiles
	{
		public int[] readFiles(string fileName)
		{
			fileName = fileName + ".txt"; //allows this method to work with any file name

            string[] readRoadFiles = File.ReadAllLines(fileName); //writes .txt to string file

			int[] convertedRoadFiles = Array.ConvertAll(readRoadFiles, int.Parse); //converts string array to int array
			
            return convertedRoadFiles; //returns an integer array
		}
	}
}

