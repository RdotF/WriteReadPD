namespace PD1;

public class Writer
{
    static string GetMessg()
    {
        string messg = Console.ReadLine();
        return messg;
    }


    internal void WriteFile()
    {
        Console.WriteLine("Write in File:");
        PD1.Program path = new Program();
        
        using (StreamWriter writer = new StreamWriter(path.GetPath(), true))
        {
            writer.WriteLine(GetMessg());
        }
        
    }
}