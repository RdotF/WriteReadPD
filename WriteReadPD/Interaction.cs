namespace PD1;

class Interaction
{
    public string AskContinue()
    {
        Console.WriteLine("Do you want to continue writing in file?[Y/n]");
        return Console.ReadLine();
    }
    public string GetMessg() 
    {
        return Console.ReadLine();;
    }
  
}