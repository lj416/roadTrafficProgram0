using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadTrafficProgram
{
	public class ReadTextFiles
	{

		public string[] readFiles(string fileName)
		{
			fileName = fileName + ".txt"; //allows this method to work with any file name
            string[] readRoadFiles = File.ReadAllLines(fileName);
			return readRoadFiles; //returns a string
		}

		

		
	}
}

