using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Flashcards
    {
        int Id { get; set; }
        int StackId { get; set; }
        string? FlashcardFront { get; set; }
        string? FlashcardBack { get; set; }
    }
}
