using ConsoleTableExt;

namespace Flashcards;

internal class StacksVisualizationEngine
{
    public static void ShowStacksTable(List<Stacks> stacksData)
    {
        ConsoleTableBuilder
        .From(stacksData)
        .ExportAndWriteLine();
    }
}
