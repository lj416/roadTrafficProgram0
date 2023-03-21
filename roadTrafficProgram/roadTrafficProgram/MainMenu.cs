using System;
namespace roadTrafficProgram
{
	public class Menu
	{

        //MAIN MENU-------------------------------------------------------------
        public static void MainMenu()
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
                    Menu.SortMenu();
                }
				else if (userChoice == "2") //quit
				{
                    //Console.WriteLine("running 2");
                    //Console.ReadKey(); //wait for any key input before clearing the console
                    //Menu.MainMenu();
                    menuFlag = false;
                }
                /*
				else if (userChoice == "3")
				{
					Console.WriteLine("running 3");
                    Console.ReadKey();
                    Menu.MainMenu();
                }
                */
				else //invalid input handling
				{
					Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
					Console.ReadKey();
					Menu.MainMenu();
				}
			}
        }

        //SORT MENU------------------------------------------------------------
        public static void SortMenu()
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
                    Menu.SearchMenu();
                }
                else if (userChoice == "2") //Insertion sort"
                {
                    Console.WriteLine("running 2");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu();
                }
                else if (userChoice == "3") //Merge sort
                {
                    Console.WriteLine("running 3");
                    Console.ReadKey();
                    Menu.MainMenu();
                }
                else if (userChoice == "4") //Quick sort
                {
                    menuFlag = false;
                }
                else if (userChoice == "5")
                {
                    Menu.MainMenu();
                }
                else
                {
                    Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
                    Console.ReadKey();
                    Menu.SearchMenu();
                }
            }
        }


        //SEARCH MENU-----------------------------------------------------------
		public static void SearchMenu()
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
                    Menu.SearchMenu();
                }
                else if (userChoice == "2") //binary search
                {
                    Console.WriteLine("running 2");
                    Console.ReadKey(); //wait for any key input before clearing the console
                    Menu.SearchMenu();
                }
                else if (userChoice == "3") //back to main menu
                {
                    Console.WriteLine("running 3");
                    Console.ReadKey();
                    Menu.MainMenu();
                }
                else if (userChoice == "4") //quit
                {
                    menuFlag = false;
                }
                else 
                {
                    Console.WriteLine("\nInvalid input.\nPress any key to try again.\n");
                    Console.ReadKey();
                    Menu.SearchMenu();
                }
            }
        }
	}
}

