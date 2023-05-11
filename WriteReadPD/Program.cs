using System;
using System.IO;
using System.Linq;
using System.Text;
using PD1.Interfaces;


namespace PD1
{
    public class Program
    {
        static void Main()
        {
            CommmandRequester commanRequester = new CommmandRequester();
            CommandReciever commandReciever = new CommandReciever();

            string comm = "";
            ConsoleStartMessage.StartMessage();
            while(true)
            {
                comm = commanRequester.AskCommand();
                commandReciever.ReceiveCommand(comm);
                
            } 
        }
    }
    
   
}