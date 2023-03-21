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
            ReadTextFiles road_1_2048 = new ReadTextFiles();
            ReadTextFiles road_2_2048 = new ReadTextFiles();
            ReadTextFiles road_3_2048 = new ReadTextFiles();


            //stores the arrays in strings

            int[] Road_1_256_textfile = road_1_256.readFiles("Road_1_256");
            int[] Road_2_256_textfile = road_2_256.readFiles("Road_2_256");
            int[] Road_3_256_textfile = road_3_256.readFiles("Road_3_256");
            int[] Road_1_2048_textfile = road_1_2048.readFiles("Road_1_2048");
            int[] Road_2_2048_textfile = road_2_2048.readFiles("Road_2_2048");
            int[] Road_3_2048_textfile = road_3_2048.readFiles("Road_3_2048");

            //iterates through the array to output all values, otherwise it outputs System.string[]
            /*
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            */

            //bubble sort for the 3 arrays


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
            /*
            var reverseinsertionmethod = new sortingAlgorithms();

            var reverseroads = reverseinsertionmethod.reverseInsertionSort(Road_1_256_textfile);

            foreach (var road in reverseroads)
            {
                Console.WriteLine(road);
            }
            */

            //reverseinsertionmethod.reverseInsertionSort(Road_1_256_textfile);

            /*
            a_road_1_256.insertionSort(Road_1_256_textfile);
            a_road_2_256.insertionSort(Road_2_256_textfile);
            a_road_3_256.insertionSort(Road_3_256_textfile);
            */

            /*
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            */

            /* -------merge sort code working
            a_road_1_256.mergeSort(Road_1_256_textfile, 0, 255);
            a_road_2_256.mergeSort(Road_2_256_textfile, 0, 255);
            a_road_3_256.mergeSort(Road_3_256_textfile, 0, 255);
            Console.WriteLine("--------------merge sort-------------");
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            */



            bool validSortFlag = true;
            
            while (validSortFlag = true)

            {
                bool validFileFlag = true; //initialise to allow for a different file to be sorted
                //SORT CHOICE
                //Console.Clear(); //clear the console for each main menu output
                Console.WriteLine("\n--SELECT SORT--");
                Console.WriteLine("1. Bubble sort"); //all ascending
                Console.WriteLine("2. Insertion sort");
                Console.WriteLine("3. Merge Sort");
                Console.WriteLine("4. Quick Sort");
                Console.WriteLine("Enter a value from 1-4");
                string sortChoice = Console.ReadLine();

                if (sortChoice == "1") //bubble sort
                {
                    //Console.Clear(); //clear the console for each main menu output         
                    while (validFileFlag = true)
                    {
                        Console.WriteLine("\n--SELECT FILE--");
                        Console.WriteLine("1. Road_1_256");
                        Console.WriteLine("2. Road_2_256");
                        Console.WriteLine("3. Road_3_256");
                        Console.WriteLine("4. Road_1_2048");
                        Console.WriteLine("5. Road_2_2048");
                        Console.WriteLine("6. Road_3_2048");
                        Console.WriteLine("7. Back");
                        Console.Write("Enter an option 1-7.");
                        string fileChoice = Console.ReadLine();

                        if (fileChoice == "1")
                        {
                            sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                            a_road_1_256.bubbleSort(Road_1_256_textfile);
                            //validFileFlag = false;
                            break; //setting the flag to exit the nested while loop does not work as expected
                        }
                        else if (fileChoice == "2")
                        {
                            sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                            a_road_2_256.bubbleSort(Road_2_256_textfile);
                            break;
                        }
                        else if (fileChoice == "3")
                        {
                            sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                            a_road_3_256.bubbleSort(Road_3_256_textfile);
                            break;
                        }
                        else if (fileChoice == "4")
                        {
                            sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                            a_road_1_2048.bubbleSort(Road_1_2048_textfile);
                            break;
                        }
                        else if (fileChoice == "5")
                        {
                            sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                            a_road_2_2048.bubbleSort(Road_2_2048_textfile);
                            break;

                        }
                        else if (fileChoice == "6")
                        {
                            sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                            a_road_3_2048.bubbleSort(Road_3_2048_textfile);
                            break;
                        }
                        else if (fileChoice == "7")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                    }
                }
                else if (sortChoice == "2") //insertion sort
                {
                    


                    while (validFileFlag = true)
                    {
                        Console.WriteLine("\n--SELECT FILE--");
                        Console.WriteLine("1. Road_1_256");
                        Console.WriteLine("2. Road_2_256");
                        Console.WriteLine("3. Road_3_256");
                        Console.WriteLine("4. Road_1_2048");
                        Console.WriteLine("5. Road_2_2048");
                        Console.WriteLine("6. Road_3_2048");
                        Console.Write("Enter an option 1-3.");
                        string fileChoice = Console.ReadLine();

                        if (fileChoice == "1")
                        {
                            sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                            a_road_1_256.insertionSort(Road_1_256_textfile);
                            break;
                        }
                        else if (fileChoice == "2")
                        {
                            sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                            a_road_2_256.insertionSort(Road_2_256_textfile);
                            break;
                        }
                        else if (fileChoice == "3")
                        {
                            sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                            a_road_3_256.insertionSort(Road_3_256_textfile);
                            break;
                        }
                        else if (fileChoice == "4")
                        {
                            sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                            a_road_1_2048.insertionSort(Road_1_2048_textfile);
                            break;
                        }
                        else if (fileChoice == "5")
                        {
                            sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                            a_road_2_2048.insertionSort(Road_2_2048_textfile);
                            break;
                        }
                        else if (fileChoice == "6")
                        {
                            sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                            a_road_3_2048.insertionSort(Road_3_2048_textfile);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }
                }
                else if (sortChoice == "3") //merge sort
                {
                    while (validFileFlag = true)
                    {
                        Console.WriteLine("\n--SELECT FILE--");
                        Console.WriteLine("1. Road_1_256");
                        Console.WriteLine("2. Road_2_256");
                        Console.WriteLine("3. Road_3_256");
                        Console.WriteLine("4. Road_1_2048");
                        Console.WriteLine("5. Road_2_2048");
                        Console.WriteLine("6. Road_3_2048");
                        Console.Write("Enter an option 1-3.");
                        string fileChoice = Console.ReadLine();

                        if (fileChoice == "1")
                        {
                            sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                            a_road_1_256.mergeSort(Road_1_256_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "2")
                        {
                            sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                            a_road_2_256.mergeSort(Road_2_256_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "3")
                        {
                            sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                            a_road_3_256.mergeSort(Road_3_256_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "4")
                        {
                            sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                            a_road_1_2048.mergeSort(Road_1_2048_textfile, 0, 2047);
                            break;
                        }
                        else if (fileChoice == "5")
                        {
                            sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                            a_road_2_2048.mergeSort(Road_2_2048_textfile, 0, 2047);
                            break;
                        }
                        else if (fileChoice == "6")
                        {
                            sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                            a_road_3_2048.mergeSort(Road_3_2048_textfile, 0, 2047);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }
                }
                else if (sortChoice == "4") //quick sort
                {
                    while (validFileFlag = true)
                    {
                        Console.WriteLine("\n--SELECT FILE--");
                        Console.WriteLine("1. Road_1_256");
                        Console.WriteLine("2. Road_2_256");
                        Console.WriteLine("3. Road_3_256");
                        Console.WriteLine("4. Road_1_2048");
                        Console.WriteLine("5. Road_2_2048");
                        Console.WriteLine("6. Road_3_2048");
                        Console.Write("Enter an option 1-3.");
                        string fileChoice = Console.ReadLine();

                        if (fileChoice == "1")
                        {
                            sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                            a_road_1_256.quickSort(Road_1_256_textfile, 0, 255);
                            foreach (var element in Road_1_256_textfile)
                            {
                                Console.WriteLine(element);
                            }
                            break;
                        }
                        else if (fileChoice == "2")
                        {
                            sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                            a_road_2_256.quickSort(Road_2_256_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "3")
                        {
                            sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                            a_road_3_256.quickSort(Road_3_256_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "4")
                        {
                            sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                            a_road_1_2048.quickSort(Road_1_2048_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "5")
                        {
                            sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                            a_road_2_2048.quickSort(Road_2_2048_textfile, 0, 255);
                            break;
                        }
                        else if (fileChoice == "6")
                        {
                            sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                            a_road_3_2048.quickSort(Road_3_2048_textfile, 0, 255);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }
                }
                else
                {

                }
            }


            /*
            //bubble sorts-----------------------------------------------------
            Console.Clear(); //clear the console for each main menu output
            Console.WriteLine("--SELECT FILE--");
            Console.WriteLine("1. Road_1_256");
            Console.WriteLine("2. Road_2_256");
            Console.WriteLine("3. Road_3_256");
            Console.WriteLine("4. Road_1_2048");
            Console.WriteLine("5. Road_2_2048");
            Console.WriteLine("6. Road_3_2048");

            bool validFileFlag = true;
            while (validFileFlag = true)
            {
                Console.Write("Enter an option 1-3.");
                string fileChoice = Console.ReadLine();

                if (fileChoice == "1")
                {
                    sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                    a_road_1_256.bubbleSort(Road_1_256_textfile);
                }
                else if (fileChoice == "2")
                {
                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                    a_road_2_256.bubbleSort(Road_2_256_textfile);
                }
                else if (fileChoice == "3")
                {
                    sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                    a_road_3_256.bubbleSort(Road_3_256_textfile);
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            */
            /*
            Console.Write("Enter an option 1-3.");
            string fileChoice = Console.ReadLine();


            if (fileChoice == "1")
            {
                Menu.MainMenu(Road_1_256_textfile);
            }
            else if (fileChoice == "2")
            {
                Menu.MainMenu(Road_2_256_textfile);
            }
            else if (fileChoice == "3")
            {
                Menu.MainMenu(Road_3_256_textfile);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            */


        }
    }
}