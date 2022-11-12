using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StackValidation
    {
        public static bool IsStackUnique(string stackName)
        {
            bool result = false;
            List<Stacks> stackData = StacksController.ViewStacksbyName(stackName);
            if (stackData == null)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
