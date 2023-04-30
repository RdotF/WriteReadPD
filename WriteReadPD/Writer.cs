namespace PD1;


class Writer
{
    public void WriteFile(string newMessg)
    {

        
        Model path = new Model();
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
            Console.WriteLine(e.Message);
        }
    }
}