namespace PD1;
using PD1.Interfaces;

public class ConsoleStartMessage
{
    public static void StartMessage()
    {
        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("Choose what to do.\nType '/read' to read from file or '/write' to write in file\n" +
                          "Type '/exit' to close program.");
        Console.WriteLine("---------------------------------------------\n");
    }

}