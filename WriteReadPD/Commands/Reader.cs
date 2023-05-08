using PD1.Interfaces;
namespace PD1;

class Reader : ICommand, IRead
{

    public void ExecuteCommand()
    {
        Console.WriteLine("\nRead from File:"); 
        ReadFile();
    }

    public void ReadFile()
    {
           
        ServiceCommExec path = new ServiceCommExec();
        try
        {
            using (StreamReader sr = File.OpenText(path.GetPath()))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("ERROR: the file could not be read!");
               
        }
    }
}