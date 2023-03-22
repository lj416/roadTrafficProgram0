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
            //initialise road txt files
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

            //function for ascending or descending choice
            static int orderMenu(int[] arrayOfIntegers) //only for bubble and insertion
            {
                bool validSortOrder = false;
                string orderChoice;
                int orderChoiceInt;
                while (validSortOrder == false)
                {
                    Console.WriteLine("\n--SELECT SORT ORDER--");
                    Console.WriteLine("1. Ascending");
                    Console.WriteLine("2. Descending");
                    Console.WriteLine("3. Back");
                    Console.WriteLine("Enter a value from 1-3");
                    orderChoice = Console.ReadLine();

                    try
                    {
                        orderChoiceInt = Int32.Parse(orderChoice);
                        if (orderChoiceInt <= 3 && orderChoiceInt >= 1)
                        {
                            validSortOrder = true;
                            return orderChoiceInt;
                        }
                        else
                        {
                            orderMenu(arrayOfIntegers);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Enter a value from 1-3");
                        orderChoice = Console.ReadLine();
                    }
                }
                return -1;
            }

            //static int
            //iterates through the array to output all values, otherwise it outputs System.string[]
            /*
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            */

            /*

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
            foreach (var value in Road_1_256_textfile)
            {
                Console.WriteLine(value);
            }
            */

        

            bool validSortFlag = true;

            bool initialMenuFlag = true;
            int userOrderChoice;
            

            while (initialMenuFlag == true)
            {
                Console.WriteLine("\nWelcome! Choose what to do\n--SELECT ACTION--"); //searching only is after the array is sorted
                Console.WriteLine("You can choose to search after sorting the files.");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Output every 10th value (for 256 lined textfiles)");
                Console.WriteLine("3. Output every 50th value (for 2048 lines textfiles)");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Enter a value from 1-4.\n>");
                string initialChoice = Console.ReadLine();

                if (initialChoice == "1") //show sort options
                {
                    while (validSortFlag = true)

                    {
                        bool validFileFlag = true; //initialise to allow for a different file to be sorted
                                                   //SORT CHOICE
                                                   //Console.Clear(); //clear the console for each main menu output
                        Console.WriteLine("\n--SELECT SORT--");
                        Console.WriteLine("1. Bubble sort");
                        Console.WriteLine("2. Insertion sort");
                        Console.WriteLine("3. Merge Sort");
                        Console.WriteLine("4. Quick Sort");
                        Console.WriteLine("Enter a value from 1-4.\n>");
                        string sortChoice = Console.ReadLine();

                        if (sortChoice == "1") //BUBBLE SORT
                        {
                            //Console.Clear(); //clear the console for each main menu output         
                            while (validFileFlag = true)
                            {
                                Console.WriteLine("You chose Insertion Sort.");

                                Console.WriteLine("\n--SELECT FILE--");
                                Console.WriteLine("1. Road_1_256");
                                Console.WriteLine("2. Road_2_256");
                                Console.WriteLine("3. Road_3_256");
                                Console.WriteLine("4. Road_1_2048");
                                Console.WriteLine("5. Road_2_2048");
                                Console.WriteLine("6. Road_3_2048");
                                Console.WriteLine("7. Back");
                                Console.Write("Enter an option 1-7\n>");
                                string fileChoice = Console.ReadLine();

                                if (fileChoice == "1")
                                {
                                    sortingAlgorithms a_road_1_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_1_256.bubbleSort(Road_1_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();
                                        
                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_256.reverseBubbleSort(Road_1_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                    //validFileFlag = false;
                                    //break; //setting the flag to exit the nested while loop does not work as expected
                                }
                                else if (fileChoice == "2")
                                {
                                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_2_256_textfile);
                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_2_256.bubbleSort(Road_2_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_256.reverseBubbleSort(Road_2_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "3")
                                {
                                    sortingAlgorithms a_road_3_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_3_256_textfile);
                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_3_256.bubbleSort(Road_3_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_256.reverseBubbleSort(Road_3_256_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "4")
                                {
                                    sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_2048_textfile);
                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_1_2048.bubbleSort(Road_1_2048_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_2048.reverseBubbleSort(Road_1_2048_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "5")
                                {
                                    sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_2_2048_textfile);
                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_2_2048.bubbleSort(Road_2_2048_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }

                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_2048.reverseBubbleSort(Road_2_2048_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }

                                }
                                else if (fileChoice == "6")
                                {
                                    sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_2048_textfile);
                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_3_2048.bubbleSort(Road_3_2048_textfile);

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.WriteLine("Enter an item to search for");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_2048.reverseBubbleSort(Road_3_2048_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "7")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again.\n");
                                }
                            }
                        }
                        else if (sortChoice == "2") //INSERTION SORT
                        {
                            while (validFileFlag = true)
                            {
                                Console.WriteLine("You chose Insertion Sort.");

                                Console.WriteLine("\n--SELECT FILE--");
                                Console.WriteLine("1. Road_1_256");
                                Console.WriteLine("2. Road_2_256");
                                Console.WriteLine("3. Road_3_256");
                                Console.WriteLine("4. Road_1_2048");
                                Console.WriteLine("5. Road_2_2048");
                                Console.WriteLine("6. Road_3_2048");
                                Console.WriteLine("7. Back");
                                Console.Write("Enter an option 1-7\n>");
                                string fileChoice = Console.ReadLine();

                                if (fileChoice == "1")
                                {
                                    sortingAlgorithms a_road_1_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_1_256.insertionSort(Road_1_256_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_256.reverseInsertionSort(Road_1_256_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "2")
                                {
                                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_2_256.insertionSort(Road_2_256_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_256.reverseInsertionSort(Road_2_256_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "3")
                                {
                                    sortingAlgorithms a_road_3_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_3_256.insertionSort(Road_3_256_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_256.reverseInsertionSort(Road_3_256_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "4")
                                {
                                    sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_1_2048.insertionSort(Road_1_2048_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_2048.reverseInsertionSort(Road_1_2048_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "5")
                                {
                                    sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_2_2048.insertionSort(Road_2_2048_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_2048.reverseInsertionSort(Road_2_2048_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "6")
                                {
                                    sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_1_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_3_2048.insertionSort(Road_3_2048_textfile);
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_2048.reverseInsertionSort(Road_3_2048_textfile);
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "7")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again.\n");
                                }
                            }
                        }
                        else if (sortChoice == "3") //MERGE SORT
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
                                Console.WriteLine("7. Back");
                                Console.Write("Enter an option 1-7\n>");
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
                                else if (fileChoice == "7")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again.\n");
                                }
                            }
                        }
                        else if (sortChoice == "4") //QUICK SORT
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
                                Console.WriteLine("7. Back");
                                Console.Write("Enter an option 1-7\n>");
                                string fileChoice = Console.ReadLine();

                                if (fileChoice == "1")
                                {
                                    sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                                    a_road_1_256.quickSort(Road_1_256_textfile, 0, 255);
                                    /*
                                    foreach (var element in Road_1_256_textfile)
                                    {
                                        Console.WriteLine(element);
                                    }
                                    */
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
                                else if (fileChoice == "7")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again.\n");
                                }
                            }
                        }
                    }
                }
                else if (initialChoice == "2") //sort by chosen asc/desc then output every 10th value
                {
                    
                    Console.WriteLine("\n--SELECT FILE--");
                    Console.WriteLine("1. Road_1_256");
                    Console.WriteLine("2. Road_2_256");
                    Console.WriteLine("3. Road_3_256");

                    Console.WriteLine("4. Back");
                    Console.Write("Enter an option 1-4\n>");
                    string fileChoice = Console.ReadLine();
                    
                    if (fileChoice == "1")
                    {
                        sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_1_256_textfile);
                        if (userOrderChoice == 1)//asc
                        {
                            a_road_1_256.insertionSort(Road_1_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");
                            for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                            {
                                
                                Console.Write(Road_1_256_textfile[i]+" , ");
                            }
                        }
                        else if (userOrderChoice == 2) //desc
                        {
                            a_road_1_256.reverseInsertionSort(Road_1_256_textfile);
                            for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_1_256_textfile[i] + " , ");
                            }
                        }
                        else if (userOrderChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
                    else if (fileChoice == "2")
                    {
                        sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_2_256_textfile);
                        if (userOrderChoice == 1)//asc
                        {
                            a_road_2_256.insertionSort(Road_2_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");
                            for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_2_256_textfile[i] + " , ");
                            }
                        }
                        else if (userOrderChoice == 2) //desc
                        {
                            a_road_2_256.reverseInsertionSort(Road_2_256_textfile);
                            for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_2_256_textfile[i] + " , ");
                            }
                        }
                        else if (userOrderChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
                    else if (fileChoice == "3")
                    {
                        sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_3_256_textfile);
                        if (userOrderChoice == 1)//asc
                        {
                            a_road_3_256.insertionSort(Road_3_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");
                            for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_3_256_textfile[i] + " , ");
                            }
                        }
                        else if (userOrderChoice == 2) //desc
                        {
                            a_road_3_256.reverseInsertionSort(Road_3_256_textfile);
                            for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_3_256_textfile[i] + " , ");
                            }
                        }
                        else if (userOrderChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
                    else if (fileChoice == "4")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    
                }
                else if (initialChoice == "3") //sort by chosen asc/desc then output every 50th value
                {

                }
                else if (initialChoice == "4") //quit
                {
                    initialMenuFlag = false;
                }
                else
                {

                }
            }



        }
    }
}