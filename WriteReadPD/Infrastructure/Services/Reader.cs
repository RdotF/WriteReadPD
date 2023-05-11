using PD1.Interfaces;
namespace PD1;

class Reader : IRead
{
  
    //internal method
    async void IRead.ReadFile(string path)
    {   
        try
        {
            string text = await File.ReadAllTextAsync(path);

            Console.WriteLine(text);
        }
        catch (IOException e)
        {
            Console.WriteLine("ERROR: the file could not be read!");
               
        }
    }
}