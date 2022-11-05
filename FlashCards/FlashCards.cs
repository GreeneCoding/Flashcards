using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    internal class FlashCards
    {
        int Id { get; set; }
        int StackId { get; set; }
        string FlashCardFront { get; set; }
        string FlashCardBack { get; set; }
    }
}
