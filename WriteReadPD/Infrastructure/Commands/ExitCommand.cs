using PD1.Interfaces;
using System.Diagnostics;
namespace PD1;

public class ExitCommand : ICommand
{
    
    public int ExecuteCommand()
    {
        Console.WriteLine("Closing Program");
        Process.GetCurrentProcess().Kill();
        return -1;
    }
}