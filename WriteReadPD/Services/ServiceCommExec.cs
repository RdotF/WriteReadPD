using System.Diagnostics;
using PD1.Interfaces;
namespace PD1;
public class ServiceCommExec
{

    public string GetPath()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.txt";

        return projectDirectory.Replace("\\", "/");
    }
    public string GetMessg() 
    {
        return Console.ReadLine();;
    }
   

    
    public void ReceiveCommand(string comm)
    {
       
    
        Dictionary<string, ICommand> parse = new Dictionary<string, ICommand>()
        {
            ["/read"] = new Reader(),
            ["/write"] = new Writer(),
            ["/exit"] = new ExitProgram()
        };
        if (string.IsNullOrWhiteSpace(comm) || !parse.ContainsKey(comm) )
        {
            Console.WriteLine("Wrong input");
        }
        else
        {
             RunCommand(parse[comm]); 
        }
    }

    private void RunCommand(ICommand comm)
    {
        Command runComm = new Command(comm);
        runComm.Execute();
    }
};
