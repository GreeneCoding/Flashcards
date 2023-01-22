using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class FlashcardsMenu
    {
        public static void ShowFlashcardsMenu()
        {
            bool returnToUserMenu = false;
            while (returnToUserMenu == false)
            {
                Console.WriteLine("\nFlashcard Management, please select one of the following options from 0 - 4");
                Console.WriteLine("\nType 1 to create a new flashcard.");
                Console.WriteLine("\nType 2 to view all flashcards by stack.");
                Console.WriteLine("\nType 3 to to update flashcards.");
                Console.WriteLine("\nType 4 to to delete flashcards.");
                Console.WriteLine("\nType 0 to return to the Main Menu.");

                var commandInput = Console.ReadLine();
                switch (commandInput)
                {
                    case "0":
                        Console.Clear();
                        returnToUserMenu = true;
                        break;
                    case "1":
                        FlashcardProcesses.CreateFlashCardsProcess();
                        break;
                    case "2":

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
