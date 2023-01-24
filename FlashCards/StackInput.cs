using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StackInput
    {
        public static string GetStackName()
        {
            Console.WriteLine($"Please enter the name of the stack that you would like to view flashcards for. Or enter 0 to return to the Flashcards Menu.");
            string stackName = Console.ReadLine();
            if (stackName == "0") FlashcardsMenu.ShowFlashcardsMenu();

            bool stackExists = StackValidation.StackExists(stackName);
            while (stackExists == false)
            {
                Console.WriteLine("The stack you have entered does not exist, please try again.");
                stackName = Console.ReadLine();
                
                stackExists = StackValidation.StackExists(stackName);

            }

            return stackName;
        }
        public static string GetNewStackName()
        {
            Console.WriteLine("Please enter the name of your new stack. Enter 0 to return to the Stacks Menu");
            string stackName = Console.ReadLine();
            if (stackName == "0") StacksMenu.ShowStacksMenu();

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
            Console.WriteLine("Please enter the Id of the stack you would like to perform the selected operation against. Enter 0 to return to the Stacks Menu");
            string id = Console.ReadLine();
            if (id == "0") StacksMenu.ShowStacksMenu();

            bool checkValidId = StackValidation.ValidId(id);
            while (checkValidId == true)
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
