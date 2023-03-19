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
			fileName = fileName + ".txt";
			string[] readRoadFiles = File.ReadAllLines(fileName);
			return readRoadFiles;
		}

		

		
	}
}

