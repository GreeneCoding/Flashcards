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

        public static int GetStackId()
        {
            Console.WriteLine("Please enter the Id of the stack you would like to update");
            string id = Console.ReadLine();

            bool checkValidId = StackValidation.ValidId(id);
            while ( checkValidId == true)
            {
                Console.WriteLine("Invalid id entered, please try again.");
                id = Console.ReadLine();

                checkValidId = StackValidation.ValidId(id);
            }

            bool idExists = StackValidation.ValidIdExists(id);
            while (idExists == false)
            {
                Console.WriteLine("Id does not exists, please try again");
                id = Console.ReadLine();

                idExists = StackValidation.ValidIdExists(id);
            }

            int validId = Convert.ToInt32(id);

            return validId;
        }
    }
}
