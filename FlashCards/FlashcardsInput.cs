using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class FlashcardsInput
    {
        public static string GetFlashcardFront()
        {
            Console.WriteLine("Please enter the contents of the front of the Flashcard. Or enter 0 to return to the Flashcard Menu.");
            string flashcardFront = Console.ReadLine();

            if (flashcardFront == "0")
            {
                FlashcardsMenu.ShowFlashcardsMenu();
            }
            else
            {
                Console.WriteLine($"{flashcardFront} has been saved to the Flashcard.");
            }

            return flashcardFront;
        }

        public static string GetFlashcardBack()
        {
            Console.WriteLine("Please enter the contents of the back of the Flashcard. Or enter 0 to return to the Flashcard Menu.");
            string flashcardBack = Console.ReadLine();

            if (flashcardBack == "0")
            {
                FlashcardsMenu.ShowFlashcardsMenu();
            }
            else
            {
                Console.WriteLine("{flashcardBack} has been saved to the Flashcard.");
            }

            return flashcardBack;
        }
    }
}
