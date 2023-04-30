
namespace PD1;

class Reader
{
    public void ReadFile()
    { 
        
        Model path = new Model();
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