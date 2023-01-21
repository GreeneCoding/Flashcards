using Flashcards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    internal class FlashcardProcesses
    {
        //Collect User Input for FlashCards, get stack info, and complete validation here, and finally call the FlashCards Controller
        //(link different methods here from other classes here to complete the above)
        public static void CreateFlashCardsProcess()
        {
            int stackId = FlashcardsInput.;
            string flashcardFront = FlashcardsInput.;
            string flashcardBack = FlashcardsInput.;
            FlashcardsController.CreateFlashcards(stackId, flashcardFront,flashcardBack);
        }

    }
}
