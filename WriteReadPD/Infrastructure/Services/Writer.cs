using System.Text;
using PD1.Interfaces;

namespace PD1;


public class Writer :  IWrite
{
   
    public async Task WriteFile(string text, string path)
    {
        try
            {  
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    await writer.WriteAsync(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: couldn't write in file");
            }
        }
        
    } 

