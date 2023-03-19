using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace roadTrafficProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextFiles road_1_256 = new ReadTextFiles();
            ReadTextFiles road_2_256 = new ReadTextFiles();
            ReadTextFiles road_3_256 = new ReadTextFiles();

            //stores the arrays in strings
            string[] Road_1_256_textfile = road_1_256.readFiles("Road_1_256");
            string[] Road_2_256_textfile = road_2_256.readFiles("Road_2_256");
            string[] Road_3_256_textfile = road_3_256.readFiles("Road_3_256");

            //iterates through the array to output all values, otherwise it outputs System.string[]
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            


        }
    }
}