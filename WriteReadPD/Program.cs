using System;
using System.IO;
using System.Linq;
using System.Text;

namespace PD1
{   
    class Program
    {
        public string GetPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.txt";
      
            return projectDirectory.Replace("\\", "/");
        } 

        public string AskContinue()
        {
            Console.WriteLine("Do you want to continue writing in file?[Y/n]");
            return Console.ReadLine();
        }
        static void Main()
        {
          
            Writer wrFile = new Writer();
            Reader rdFile = new Reader();
            Program askUser = new Program();
            string ans = "";
            
            do
            {    
                wrFile.WriteFile();
                rdFile.ReadFile();;
                ans = askUser.AskContinue();
            } while (ans == "y" || ans == "Y");
        }
    }
}