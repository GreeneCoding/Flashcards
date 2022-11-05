using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    internal class StudySession
    {
        int Id { get; set; }
        int StackId { get; set; }
        DateTime StudyDate { get; set; }
        int NumberCorrect { get; set; }
        int TotalQuestions { get; set; }
    }
}
