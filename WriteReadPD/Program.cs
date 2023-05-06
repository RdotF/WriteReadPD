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
            AwaitComm awaitComm = new AwaitComm();
            ServiceCommExec execute = new ServiceCommExec();

            string comm = "";
           
            while(true)
            {
                comm = awaitComm.AskCommand();
                execute.ReceiveCommand(comm);
                
            } 
        }
    }
    
   
}