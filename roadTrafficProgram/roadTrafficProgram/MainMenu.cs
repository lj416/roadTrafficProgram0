using System;
namespace roadTrafficProgram
{
    public class Menu
    {

        //MAIN MENU-------------------------------------------------------------
        public static void MainMenu(int[] arrayOfNums)
		{
			bool menuFlag = true;

			Console.Clear(); //clear the console for each main menu output
			Console.WriteLine("--MAIN MENU--");
			Console.WriteLine("1. Sort");
			Console.WriteLine("2. Quit");
			Console.Write("Enter an option 1-2.");

			string userChoice = Console.ReadLine();

			while (menuFlag = true)
			{
				if (userChoice == "1") //show sorting algorithms
				{
                    Menu.SortMenu(arrayOfNums);
                }
				else if (userChoice == "2") //quit
				{
                    menuFlag = false;
                }
				else //invalid input handling
				{
					Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
					Console.ReadKey();
					Menu.MainMenu(arrayOfNums);
				}
			}
        }

        //SORT MENU------------------------------------------------------------
        public static void SortMenu(int[] arrayOfNums)
        {
            bool menuFlag = true;

            Console.Clear(); //clear the console for each main menu output
            Console.WriteLine("--SORT MENU--");
            Console.WriteLine("1. Bubble sort");
            Console.WriteLine("2. Insertion sort");
            Console.WriteLine("3. Merge sort");
            Console.WriteLine("4. Quick sort");
            Console.WriteLine("5. Back to main menu");
            Console.Write("Enter an option 1-5.");
            string userChoice = Console.ReadLine();

            while (menuFlag = true)
            {
                if (userChoice == "1") //Bubble sort
                {
                    
                    Console.WriteLine("running 1");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu(arrayOfNums);
                }
                else if (userChoice == "2") //Insertion sort"
                {
                    Console.WriteLine("running 2");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu(arrayOfNums);
                }
                else if (userChoice == "3") //Merge sort
                {
                    Console.WriteLine("running 3");
                    Console.ReadKey();
                    Menu.MainMenu(arrayOfNums);
                }
                else if (userChoice == "4") //Quick sort
                {
                    menuFlag = false;
                }
                else if (userChoice == "5")
                {
                    Menu.MainMenu(arrayOfNums);
                }
                else
                {
                    Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
                    Console.ReadKey();
                    Menu.SearchMenu(arrayOfNums);
                }
            }
        }


        //SEARCH MENU-----------------------------------------------------------
		public static void SearchMenu(int[] arrayOfNums)
		{
            bool menuFlag = true;

            Console.Clear(); //clear the console for each main menu output
            Console.WriteLine("--SEARCH MENU--");
            Console.WriteLine("1. Linear search");
            Console.WriteLine("2. Binary search");
            Console.WriteLine("3. Back to main menu");
            Console.WriteLine("4. Quit");
            Console.Write("Enter an option 1-4.");
            string userChoice = Console.ReadLine();

            while (menuFlag = true)
            {
                if (userChoice == "1") //linear search
                {
                    Console.WriteLine("running 1");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu(arrayOfNums);
                }
                else if (userChoice == "2") //binary search
                {
                    Console.WriteLine("running 2");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu(arrayOfNums);
                }
                else if (userChoice == "3") //back to main menu
                {
                    Console.WriteLine("running 3");
                    Console.ReadKey();
                    Menu.MainMenu(arrayOfNums);
                }
                else if (userChoice == "4") //quit
                {
                    menuFlag = false;
                }
                else 
                {
                    Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
                    Console.ReadKey();
                    Menu.SearchMenu(arrayOfNums);
                }
            }
        }


	}
}

