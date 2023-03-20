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
            //initialise short road txt files
            ReadTextFiles road_1_256 = new ReadTextFiles();
            ReadTextFiles road_2_256 = new ReadTextFiles();
            ReadTextFiles road_3_256 = new ReadTextFiles();

            //stores the arrays in strings
            int[] Road_1_256_textfile = road_1_256.readFiles("Road_1_256");
            int[] Road_2_256_textfile = road_2_256.readFiles("Road_2_256");
            int[] Road_3_256_textfile = road_3_256.readFiles("Road_3_256");

            //iterates through the array to output all values, otherwise it outputs System.string[]
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }


            //bubble sort for the 3 arrays
            
            sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
            sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
            sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
            /*
            a_road_1_256.bubbleSort(Road_1_256_textfile);
            a_road_2_256.bubbleSort(Road_2_256_textfile);
            a_road_3_256.bubbleSort(Road_3_256_textfile);
            

            //checking output for bubble sort -> WORKING
            Console.WriteLine("--------------bubble sort-------------");
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            
            */
            //insertion sort
            
            a_road_1_256.insertionSort(Road_1_256_textfile);
            a_road_2_256.insertionSort(Road_2_256_textfile);
            a_road_3_256.insertionSort(Road_3_256_textfile);

            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }


        }
    }
}