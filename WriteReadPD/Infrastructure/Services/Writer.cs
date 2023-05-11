using PD1.Interfaces;

namespace PD1;


class Writer :  IWrite
{
    //internal method
    async void IWrite.WriteFile(string text, string path)
    {
        if (!string.IsNullOrWhiteSpace(text))
        {
            try
            {
                await File.WriteAllTextAsync(path, text);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: couldn't write in file");
            }
        }
        else {
            Console.WriteLine("No input");
        }
    } 



}