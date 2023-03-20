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
            string[] readRoadFiles = File.ReadAllLines(fileName);

			int[] convertedRoadFiles = Array.ConvertAll(readRoadFiles, int.Parse);
			/*
			foreach (string value in readRoadFiles)
            {
				
            }
			*/
            return convertedRoadFiles; //returns an integer array
		}

		

		
	}
}

