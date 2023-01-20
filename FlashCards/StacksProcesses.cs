using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StacksProcesses
    {
        //Collect User Input for stacks, get stack info, and complete validation here, and finally call the Stacks Controller
        //(link different methods here from other classes here to complete the above)

        public static void CreateStackProcess()
        {
            string stackName = StackInput.GetNewStackName();
            StacksController.CreateStacks(stackName);
        }

        public static void GetStacksProcess()
        {
            List<Stacks> stacksData = StacksController.ViewStacksTable();
            StacksVisualizationEngine.ShowStacksTable(stacksData);
        }

        public static void GetStacksIdProcess(string id)
        {
            StacksController.GetStacksId(id);
        }

        public static void UpdateStackName()
        {
            GetStacksProcess();
            int id = StackInput.GetStackId();
            string stackName = StackInput.GetNewStackName();
            StacksController.UpdateStacks(id, stackName);
        }

        public static void DeleteStack()
        {
            GetStacksProcess();
            int id = StackInput.GetStackId();
            StacksController.DeleteStacks(id);
        }
    }
}
