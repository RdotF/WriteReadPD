namespace PD1;

public class AwaitComm
{
    public string AskCommand()
    {   Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("Choose what to do.\nType '/read' to read from file or '/write' to write in file\n" +
                          "Type '/exit' to close program.");
        Console.WriteLine("---------------------------------------------\n");
        return Console.ReadLine();
    }
   
  
}