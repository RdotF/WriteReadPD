using System;
using System.IO;
using System.Linq;
using System.Text;


namespace PD1
{
    public class Program
    {

        static void Main()
        {   
            Interaction interaction = new Interaction();
            Model _model = new Model();
            Writer wrFile = new Writer();
            Reader rdFile = new Reader();
            string ans = "";
           
            do
            {
                
                _model.SendMessgWrite();
                wrFile.WriteFile(interaction.GetMessg());
                _model.SendMessgRead();
                rdFile.ReadFile();;
                ans = interaction.AskContinue();

            } while (ans == "y" || ans == "Y");
        }
    }
    
   
}