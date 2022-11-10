using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class UserMenu
    {
        internal static void ShowUserMenu()
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("\nWelcome to the Flashcards App Main Menu, please select one of the following options from 0 - 4");
                Console.WriteLine("\nType 1 to manage Stacks.");
                Console.WriteLine("\nType 2 to manage Flashcards.");
                Console.WriteLine("\nType 3 to begin a study session.");
                Console.WriteLine("\nType 4 to view past study sessions.");
                Console.WriteLine("\nType 0 to exit the Flashcards app.");

                var commandInput = Console.ReadLine();
                switch (commandInput)
                {
                    case "0":
                        Console.WriteLine(@"Thank you for using the Flashcards App, Goodbye!");
                        closeApp = true;
                        break;
                    case "1":
                        
                        break;
                    case "2":
                        Console.Clear();
                        FlashcardsMenu.ShowFlashcardsMenu();
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    default:
                        Console.WriteLine(@"Invalid input, please enter a value from 0-4");
                        break;
                }
            }
        }
        
        
	
    }
}
