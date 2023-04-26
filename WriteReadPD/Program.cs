

namespace PD1
{
    public class Program
    {
        static void Main()
        {       
            CommmandRequester commandRequester = new CommmandRequester();
            CommandReceiverSingleton commandReceiver = CommandReceiverSingleton.Instance();

            string comm = "";
            ConsoleStartMessage.StartMessage();
            while(true)
            {
                comm = commandRequester.AskCommand();
                if(commandReceiver != null)
                    commandReceiver.ReceiveCommand(comm);
                else 
                    Console.WriteLine("commandReceiver is null");
            } 
        }
    }
    
   
}