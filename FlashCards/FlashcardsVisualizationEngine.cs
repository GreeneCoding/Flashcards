using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class FlashcardsVisualizationEngine
    {
        public static void ShowFlashcards(List<List<object>> flashcards)
        {
            ConsoleTableBuilder
            .From(flashcards)
            .ExportAndWriteLine();
        }
    }
}
