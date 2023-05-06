using PD1.Interfaces;

namespace PD1;


class Writer : ICommand, IWrite
{

    public void ExecuteCommand()
    {
        ServiceCommExec messg = new ServiceCommExec();
        Console.WriteLine("\nWrite in File:");
        WriteFile(messg.GetMessg());
    }

    public void WriteFile(string newMessg)
        {

            ServiceCommExec path = new ServiceCommExec();
            try
            {
                using (StreamWriter writer = new StreamWriter(path.GetPath(), true))
                {
                    writer.WriteLine(newMessg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: couldn't write in file");
            }
        
    }
}