﻿using Flashcards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class FlashcardProcesses
    {
        //Collect User Input for FlashCards, get stack info, and complete validation here, and finally call the FlashCards Controller
        //(link different methods here from other classes here to complete the above)
        public static void CreateFlashcardsProcess()
        {
            StacksProcesses.GetStacksProcess();
            int stackId = StackInput.GetStackId();
            string flashcardFront = FlashcardsInput.GetFlashcardFront();
            string flashcardBack = FlashcardsInput.GetFlashcardBack();
            FlashcardsController.CreateFlashcards(stackId, flashcardFront,flashcardBack);
        }

        public static void GetFlashcardsByStackName()
        {
            StacksProcesses.GetStacksProcess();
            
            string stackName =  StackInput.GetStackName();
            List<FlashcardsDTO> flashcardsData = FlashcardsController.GetFlashcardsbyStackName(stackName);
            var flashcards = new List<List<object>>();
            foreach (FlashcardsDTO flashcard in flashcardsData)
            {
                flashcards.Add(new List<object> { flashcardsData.IndexOf(flashcard) + 1, flashcard.flashcardFront, flashcard.flashcardBack });
            }

            FlashcardsVisualizationEngine.ShowFlashcards(flashcards);

        }

    }
}
