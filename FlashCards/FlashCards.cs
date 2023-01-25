using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Flashcards
    {
        public int Id { get; set; }
        public int StackId { get; set; }
        public string? FlashcardFront { get; set; }
        public string? FlashcardBack { get; set; }
    }
}
