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
            string stackName = Console.ReadLine();
            bool stackUnique = StackValidation.IsStackUnique(stackName);
            while (stackUnique == false)
            {
                Console.WriteLine("Stack name is already in use. Please try again");
                stackName = Console.ReadLine();
                stackUnique = StackValidation.IsStackUnique(stackName);
            }
           
            return stackName;
        }
    }
}
