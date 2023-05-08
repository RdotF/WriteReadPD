using PD1.Interfaces;
using System.Diagnostics;
namespace PD1;

public class ExitProgram : ICommand
{
   public void ExecuteCommand()
   {
      Console.WriteLine("Closing Program");
      Process.GetCurrentProcess().Kill();
      
   }
}