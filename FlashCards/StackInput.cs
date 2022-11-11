using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StackInput
    {
        public static string GetNewStackName()
        {
            Console.WriteLine("Please enter the name of your new stack.");
            string stackname = Console.ReadLine();
            return stackname;
        }
    }
}
