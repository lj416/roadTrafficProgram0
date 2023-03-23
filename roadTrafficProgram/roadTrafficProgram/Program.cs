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
                            orderMenu(arrayOfIntegers); //calls itself to start again
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

            bool validSortFlag = true;
            bool initialMenuFlag = true; //first menu
            int userOrderChoice;
            

            while (initialMenuFlag == true)
            {
                Console.WriteLine("\nWelcome!\n\n--SELECT ACTION--"); //searching only is after the array is sorted
                Console.WriteLine("\n(You can choose to search after sorting the files.)\n");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Output every 10th value (for 256 lines textfiles)");
                Console.WriteLine("3. Output every 50th value (for 2048 lines textfiles)");
                Console.WriteLine("4. Merge Road_1_256.txt and Road_3_256");
                Console.WriteLine("5. Merge Road_1_2048.txt and Road_3_2048");
                Console.WriteLine("6. Quit");
                Console.Write("Enter a value from 1-6.\n>");
                string initialChoice = Console.ReadLine();

                if (initialChoice == "1") //show sort options
                {
                    while (validSortFlag = true)

                    {
                        bool validFileFlag = true; //initialise to allow for a different file to be sorted
                                                   //SORT CHOICE
                                                   
                        Console.WriteLine("\n--SELECT SORT--");
                        Console.WriteLine("1. Bubble sort");
                        Console.WriteLine("2. Insertion sort");
                        Console.WriteLine("3. Merge Sort");
                        Console.WriteLine("4. Quick Sort");
                        Console.WriteLine("5. Back");
                        Console.Write("Enter a value from 1-5.\n>");
                        string sortChoice = Console.ReadLine();

                        if (sortChoice == "1") //BUBBLE SORT
                        {
                            //Console.Clear(); //clear the console for each main menu output         
                            while (validFileFlag = true)
                            {
                                Console.WriteLine("You chose Bubble Sort.");

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

                                    if (userOrderChoice == 1) //ascending bubble sort
                                    {
                                        a_road_1_256.bubbleSort(Road_1_256_textfile);

                                        Console.WriteLine("\nOutputting every 10th value:"); //outputs every 10th value
                                        for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_1_256_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1") //linear search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2") //binary search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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
                                    else if (userOrderChoice == 2) //descending bubble sort
                                    {
                                        a_road_1_256.reverseBubbleSort(Road_1_256_textfile);

                                        Console.WriteLine("\nOutputting every 10th value:"); //output every 10th value
                                        for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_1_256_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1") //linear search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2") //binary search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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
                                    if (userOrderChoice == 1) //ascending bubble sort
                                    {
                                        a_road_2_256.bubbleSort(Road_2_256_textfile);

                                        Console.WriteLine("\nOutputting every 10th value:");
                                        for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_2_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1") //linear search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2") //binary search
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 10th value:");
                                        for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_2_256_textfile[i] + " , ");
                                        }

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 10th value:");
                                        for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_3_256_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 10th value:");
                                        for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                        {

                                            Console.Write(Road_3_256_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_1_2048_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_1_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_2_2048_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_2_2048_textfile[i] + "  "); 
                                        }

                                        Console.WriteLine("--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_3_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 50th value:");
                                        for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                                        {

                                            Console.Write(Road_3_2048_textfile[i] + "  ");
                                        }

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
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

                                        Console.WriteLine("\nOutputting every 10th value: ");
                                        for (int i = 0; i < Road_1_256_textfile.Length; i+=10)
                                        {
                                            Console.Write(Road_1_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_256.reverseInsertionSort(Road_1_256_textfile);
                                        Console.WriteLine("\nOutputting every 10th value: ");
                                        for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                                        {
                                            Console.Write(Road_1_256_textfile[i] + "  ");
                                        }
                                        break;
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "2")
                                {
                                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_2_256_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_2_256.insertionSort(Road_2_256_textfile);
                                        Console.WriteLine("Outputting every 10th value: ");
                                        for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                        {
                                            Console.Write(Road_2_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_256.reverseInsertionSort(Road_2_256_textfile);
                                        Console.WriteLine("\nOOutputting every 10th value: ");
                                        for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                        {
                                            Console.Write(Road_2_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        break;
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
                                        a_road_3_256.insertionSort(Road_3_256_textfile);
                                        Console.WriteLine("Outputting every 10th value: ");
                                        for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                        {
                                            Console.Write(Road_3_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_256.reverseInsertionSort(Road_3_256_textfile);
                                        Console.WriteLine("\nOOutputting every 10th value: ");
                                        for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                        {
                                            Console.Write(Road_3_256_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        break;
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
                                        a_road_1_2048.insertionSort(Road_1_2048_textfile);
                                        Console.WriteLine("Outputting every 50th value: ");
                                        for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_1_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_1_2048.reverseInsertionSort(Road_1_2048_textfile);
                                        Console.WriteLine("\nOOutputting every 50th value: ");
                                        for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_1_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");
                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
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
                                        a_road_2_2048.insertionSort(Road_2_2048_textfile);
                                        Console.WriteLine("Outputting every 50th value: ");
                                        for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_2_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_2_2048.reverseInsertionSort(Road_2_2048_textfile);
                                        Console.WriteLine("\nOOutputting every 50th value: ");
                                        for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_2_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
                                    }
                                    else if (userOrderChoice == 3) //quit
                                    {
                                        break;
                                    }
                                }
                                else if (fileChoice == "6")
                                {
                                    sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();

                                    userOrderChoice = orderMenu(Road_3_2048_textfile);

                                    if (userOrderChoice == 1) //ascending
                                    {
                                        a_road_3_2048.insertionSort(Road_3_2048_textfile);
                                        Console.WriteLine("\nOutputting every 50th value: ");
                                        for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_3_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
                                    }
                                    else if (userOrderChoice == 2) //descending
                                    {
                                        a_road_3_2048.reverseInsertionSort(Road_3_2048_textfile);
                                        Console.WriteLine("\nOutputting every 50th value: ");
                                        for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                                        {
                                            Console.Write(Road_3_2048_textfile[i] + "  ");
                                        }
                                        Console.WriteLine("\n");

                                        Console.WriteLine("\n--Choose which search to use--");
                                        Console.WriteLine("1. Linear search");
                                        Console.WriteLine("2. Binary search");
                                        Console.WriteLine("3. Quit");
                                        Console.Write("Enter an option 1-3\n>");
                                        string searchChoice = Console.ReadLine();

                                        Console.Write("Enter an item to search for\n>");
                                        string itemToSearch = Console.ReadLine();

                                        if (searchChoice == "1")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "2")
                                        {
                                            searchingAlgorithms s = new searchingAlgorithms();
                                            s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                            break;
                                        }
                                        else if (searchChoice == "3")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.\n");
                                        }
                                        break;
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
                                Console.WriteLine("You chose Merge Sort");
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

                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_1_256_textfile[i] + "  ");
                                    }
                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "2")
                                {
                                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                                    a_road_2_256.mergeSort(Road_2_256_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_2_256_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "3")
                                {
                                    sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                                    a_road_3_256.mergeSort(Road_3_256_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_3_256_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "4")
                                {
                                    sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                                    a_road_1_2048.mergeSort(Road_1_2048_textfile, 0, 2047);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_1_2048_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "5")
                                {
                                    sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                                    a_road_2_2048.mergeSort(Road_2_2048_textfile, 0, 2047);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_2_2048_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "6")
                                {
                                    sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                                    a_road_3_2048.mergeSort(Road_3_2048_textfile, 0, 2047);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_1_2048_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
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
                                Console.WriteLine("You chose Quick Sort.");
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
                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_1_256_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "2")
                                {
                                    sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                                    a_road_2_256.quickSort(Road_2_256_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_2_256_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "3")
                                {
                                    sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                                    a_road_3_256.quickSort(Road_3_256_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 10th value: ");
                                    for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                                    {
                                        Console.Write(Road_3_256_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "4")
                                {
                                    sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                                    a_road_1_2048.quickSort(Road_1_2048_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_1_2048_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "5")
                                {
                                    sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                                    a_road_2_2048.quickSort(Road_2_2048_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_2_2048_textfile[i] + "  ");
                                    }
                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
                                    break;
                                }
                                else if (fileChoice == "6")
                                {
                                    sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                                    a_road_3_2048.quickSort(Road_3_2048_textfile, 0, 255);
                                    Console.WriteLine("\nOutputting every 50th value: ");
                                    for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                                    {
                                        Console.Write(Road_3_2048_textfile[i] + "  ");
                                    }

                                    Console.WriteLine("\n--Choose which search to use--");
                                    Console.WriteLine("1. Linear search");
                                    Console.WriteLine("2. Binary search");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("Enter an option 1-3\n>");
                                    string searchChoice = Console.ReadLine();

                                    Console.Write("Enter an item to search for\n>");
                                    string itemToSearch = Console.ReadLine();

                                    if (searchChoice == "1")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "2")
                                    {
                                        searchingAlgorithms s = new searchingAlgorithms();
                                        s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                        break;
                                    }
                                    else if (searchChoice == "3")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.\n");
                                    }
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
                        else if (sortChoice == "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input, try again.\n");
                        }
                    }
                }
//-----------------------------------------------------------------------------
                else if (initialChoice == "2") //SORT BY CHOSEN ASC/DESC THEN OUTPUT EVERY 10TH VALUE
                {
                    Console.WriteLine("You chose to output every 10th value.");
                    Console.WriteLine("\n--SELECT FILE--");
                    Console.WriteLine("1. Road_1_256");
                    Console.WriteLine("2. Road_2_256");
                    Console.WriteLine("3. Road_3_256");

                    Console.WriteLine("4. Back");
                    Console.Write("Enter an option 1-4\n>");
                    string fileChoice = Console.ReadLine();

                    if (fileChoice == "1") //text file 1 256
                    {
                        sortingAlgorithms a_road_1_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_1_256_textfile);

                        if (userOrderChoice == 1)//ascending 10th values
                        {
                            a_road_1_256.insertionSort(Road_1_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");

                            for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_1_256_textfile[i] + " , ");
                            }
                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 10 values
                        {
                            a_road_1_256.reverseInsertionSort(Road_1_256_textfile);

                            for (int i = 0; i < Road_1_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_1_256_textfile[i] + " , ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 3) //quit to main menu
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
                    else if (fileChoice == "2") //text file 2 256
                    {
                        sortingAlgorithms a_road_2_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_2_256_textfile);

                        if (userOrderChoice == 1)//ascending 10th values
                        {
                            a_road_2_256.insertionSort(Road_2_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");

                            for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_2_256_textfile[i] + " , ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 10th values
                        {
                            a_road_2_256.reverseInsertionSort(Road_2_256_textfile);

                            for (int i = 0; i < Road_2_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_2_256_textfile[i] + " , ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
                    else if (fileChoice == "3") //textfile 3 256
                    {
                        sortingAlgorithms a_road_3_256 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_3_256_textfile);

                        if (userOrderChoice == 1)//ascending 10th values
                        {
                            a_road_3_256.insertionSort(Road_3_256_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");

                            for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_3_256_textfile[i] + "  ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 10th values
                        {
                            a_road_3_256.reverseInsertionSort(Road_3_256_textfile);

                            for (int i = 0; i < Road_3_256_textfile.Length; i += 10)
                            {

                                Console.Write(Road_3_256_textfile[i] + " , ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_256_textfile, Int32.Parse(itemToSearch));
                                break;
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
//-----------------------------------------------------------------------------
                else if (initialChoice == "3") //SORT BY CHOSEN ASC/DESC THEN OUTPUT EVERY 50TH VALUE
                {
                    Console.WriteLine("You chose to ");
                    Console.WriteLine("\n--SELECT FILE--");
                    Console.WriteLine("1. Road_1_2048");
                    Console.WriteLine("2. Road_2_2048");
                    Console.WriteLine("3. Road_3_2048");

                    Console.WriteLine("4. Back");
                    Console.Write("Enter an option 1-4\n>");
                    string fileChoice = Console.ReadLine();

                    if (fileChoice == "1") //TEXT FILE 1 2048
                    {
                        sortingAlgorithms a_road_1_2048 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_1_2048_textfile);

                        if (userOrderChoice == 1)//ascending 50th values
                        {
                            a_road_1_2048.insertionSort(Road_1_2048_textfile);
                            Console.WriteLine("\nOutputting every 50th value.");

                            for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_1_2048_textfile[i] + "  ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 50th values
                        {
                            a_road_1_2048.reverseInsertionSort(Road_1_2048_textfile);

                            for (int i = 0; i < Road_1_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_1_2048_textfile[i] + "  ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_1_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
 //-----------------------------------------------------------------------------
                    else if (fileChoice == "2") //TEXT FILE 2 2048
                    {
                        sortingAlgorithms a_road_2_2048 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_2_2048_textfile);

                        if (userOrderChoice == 1)//ascending 50th values
                        {
                            a_road_2_2048.insertionSort(Road_2_2048_textfile);
                            Console.WriteLine("\nOutputting every 10th value.");

                            for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_2_2048_textfile[i] + "  ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 50th values
                        {
                            a_road_2_2048.reverseInsertionSort(Road_2_2048_textfile);

                            for (int i = 0; i < Road_2_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_2_2048_textfile[i] + "  ");
                            }
                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_2_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.\n");
                        }
                    }
//-----------------------------------------------------------------------------
                    else if (fileChoice == "3") //TEXT FILE 3 2048
                    {
                        sortingAlgorithms a_road_3_2048 = new sortingAlgorithms();
                        userOrderChoice = orderMenu(Road_3_2048_textfile);

                        if (userOrderChoice == 1)//ascending 50th values
                        {
                            a_road_3_2048.insertionSort(Road_3_2048_textfile);
                            Console.WriteLine("\nOutputting every 50th value.");

                            for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_3_2048_textfile[i] + "  ");
                            }
                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
                        else if (userOrderChoice == 2) //descending 50th values
                        {
                            a_road_3_2048.reverseInsertionSort(Road_3_2048_textfile);
                            for (int i = 0; i < Road_3_2048_textfile.Length; i += 50)
                            {

                                Console.Write(Road_3_2048_textfile[i] + "  ");
                            }

                            Console.WriteLine("\n--Choose which search to use--");
                            Console.WriteLine("1. Linear search");
                            Console.WriteLine("2. Binary search");
                            Console.WriteLine("3. Quit");
                            Console.Write("Enter an option 1-3\n>");
                            string searchChoice = Console.ReadLine();

                            Console.Write("Enter an item to search for\n>");
                            string itemToSearch = Console.ReadLine();

                            if (searchChoice == "1")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.linearSearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                break;
                            }
                            else if (searchChoice == "2")
                            {
                                searchingAlgorithms s = new searchingAlgorithms();
                                s.binarySearch(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                searchingAlgorithms.findDupes(Road_3_2048_textfile, Int32.Parse(itemToSearch));
                                break;
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
//-----------------------------------------------------------------------------
                else if (initialChoice == "4") //MERGE ROAD1 and ROAD3 256
                { 
                    int[] merge_Road_256 = Road_1_256_textfile; //new array for the merged array

                    for (int i = 0; i < Road_3_256_textfile.Length; i++)//merging the arrays by appending each element of one to the other
                    {
                        merge_Road_256.Append(Road_3_256_textfile[i]);
                    }
                    sortingAlgorithms a_merged_road_3_256 = new sortingAlgorithms();
                    userOrderChoice = orderMenu(merge_Road_256);

                    if (userOrderChoice == 1) //asc
                    {
                        a_merged_road_3_256.insertionSort(merge_Road_256);

                        Console.WriteLine("Outputting every 10th value.");
                        for (int i = 0; i < merge_Road_256.Length; i += 10)
                        {
                            Console.Write(merge_Road_256[i]+ "  ");
                        }

                        Console.WriteLine("\n--Choose which search to use--");
                        Console.WriteLine("1. Linear search");
                        Console.WriteLine("2. Binary search");
                        Console.WriteLine("3. Quit");
                        Console.Write("Enter an option 1-3\n>");
                        string searchChoice = Console.ReadLine();

                        Console.Write("Enter an item to search for\n>");
                        string itemToSearch = Console.ReadLine();

                        if (searchChoice == "1") //linear search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.linearSearch(merge_Road_256, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_256, Int32.Parse(itemToSearch));
                            break;
                        }
                        else if (searchChoice == "2") //binary search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.binarySearch(merge_Road_256, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_256, Int32.Parse(itemToSearch));
                            break;
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
                    else if (userOrderChoice == 2) //desc
                    {
                        a_merged_road_3_256.reverseInsertionSort(merge_Road_256);

                        Console.WriteLine("Outputting every 10th value.");
                        for (int i = 0; i < merge_Road_256.Length; i += 10)
                        {
                            Console.Write(merge_Road_256[i] + "  ");
                        }

                        Console.WriteLine("\n--Choose which search to use--");
                        Console.WriteLine("1. Linear search");
                        Console.WriteLine("2. Binary search");
                        Console.WriteLine("3. Quit");
                        Console.Write("Enter an option 1-3\n>");
                        string searchChoice = Console.ReadLine();

                        Console.Write("Enter an item to search for\n>");
                        string itemToSearch = Console.ReadLine();

                        if (searchChoice == "1") //linear search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.linearSearch(merge_Road_256, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_256, Int32.Parse(itemToSearch));
                            //break;
                        }
                        else if (searchChoice == "2") //binary search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.binarySearch(merge_Road_256, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_256, Int32.Parse(itemToSearch));
                            //break;
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

                    foreach (var value in merge_Road_256)
                    {
                        Console.Write(value + "  ");
                    }

                    Console.Write("\n\nPress any key to continue to the menu.\n");
                    Console.ReadKey();
                }
//-----------------------------------------------------------------------------
                else if (initialChoice == "5") //MERGE ROAD1 AND ROAD3 2048
                {
                    int[] merge_Road_2048 = Road_1_2048_textfile; //new array for the merged array
                    sortingAlgorithms a_merged_road_3_2048 = new sortingAlgorithms();

                    for (int i = 0; i < Road_3_2048_textfile.Length; i++)//merging the arrays by appending each element of one to the other
                    {
                        merge_Road_2048.Append(Road_3_2048_textfile[i]);
                    }


                    userOrderChoice = orderMenu(merge_Road_2048);

                    if (userOrderChoice == 1) //asc
                    {
                        a_merged_road_3_2048.insertionSort(merge_Road_2048);

                        Console.WriteLine("Outputting every 50th value.");
                        for (int i = 0; i < merge_Road_2048.Length; i += 50)
                        {
                            Console.Write(merge_Road_2048[i] + "  ");
                        }

                        Console.WriteLine("\n--Choose which search to use--");
                        Console.WriteLine("1. Linear search");
                        Console.WriteLine("2. Binary search");
                        Console.WriteLine("3. Quit");
                        Console.Write("Enter an option 1-3\n>");
                        string searchChoice = Console.ReadLine();

                        Console.Write("Enter an item to search for\n>");
                        string itemToSearch = Console.ReadLine();

                        if (searchChoice == "1") //linear search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.linearSearch(merge_Road_2048, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_2048, Int32.Parse(itemToSearch));
                            //break;
                        }
                        else if (searchChoice == "2") //binary search
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.binarySearch(merge_Road_2048, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_2048, Int32.Parse(itemToSearch));
                            //break;
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
                    else if (userOrderChoice == 2) //desc
                    {
                        a_merged_road_3_2048.reverseInsertionSort(merge_Road_2048);
                        Console.WriteLine("Outputting every 50th value.");
                        for (int i = 0; i < merge_Road_2048.Length; i += 50)
                        {
                            Console.Write(merge_Road_2048[i] + "  ");
                        }

                        Console.WriteLine("\n--Choose which search to use--");
                        Console.WriteLine("1. Linear search");
                        Console.WriteLine("2. Binary search");
                        Console.WriteLine("3. Quit");
                        Console.Write("Enter an option 1-3\n>");
                        string searchChoice = Console.ReadLine();

                        Console.Write("Enter an item to search for\n>");
                        string itemToSearch = Console.ReadLine();

                        if (searchChoice == "1") //linear
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.linearSearch(merge_Road_2048, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_2048, Int32.Parse(itemToSearch));
                            break;
                        }
                        else if (searchChoice == "2") //binary
                        {
                            searchingAlgorithms s = new searchingAlgorithms();
                            s.binarySearch(merge_Road_2048, Int32.Parse(itemToSearch));
                            searchingAlgorithms.findDupes(merge_Road_2048, Int32.Parse(itemToSearch));
                            break;
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



                    Console.Write("\n\nPress any key to continue to the menu.\n");
                    Console.ReadKey();
                }
//-----------------------------------------------------------------------------
                else if (initialChoice == "6") //QUIT
                {
                    initialMenuFlag = false;
                }
//-----------------------------------------------------------------------------
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid input.\n");
                    Thread.Sleep(500); //pause before clearing the terminal
                    Console.Clear();
                }
            }
        }
    }
}