namespace PD1;

public class Reader
{
    internal void ReadFile()
    { 
        Console.WriteLine("Read from File:");
        PD1.Program path = new Program();
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
            Console.WriteLine(e.Message);
        }
    }
}