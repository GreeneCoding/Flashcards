using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StackValidation
    {
        public static bool StackExists(string stackName)
        {
            bool result = false;
            List<Stacks> stackData = StacksController.ViewStacksbyName(stackName);
            if (stackData.Count == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        public static bool IsStackUnique(string stackName)
        {
            bool result = false;
            List<Stacks> stackData = StacksController.ViewStacksbyName(stackName);
            if (stackData.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static bool ValidIdExists(string id)
        {
           bool idExists = false;
            List<Stacks> stackId = StacksController.GetStacksId(id);
            if (stackId.Count == 0)
            {
                idExists = false;
            }
            else
            {
                idExists = true;
            }
            return idExists;

        }

        public static bool ValidId(string id)
        {
            bool validId = (!int.TryParse(id, out _) || Convert.ToInt32(id) < 0);
            return validId;
          
        }
    }
}
