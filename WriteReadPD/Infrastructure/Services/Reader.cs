using System.Text;
using PD1.Interfaces;
namespace PD1;

public class Reader : IRead
{


    public async Task ReadFile(string path){

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