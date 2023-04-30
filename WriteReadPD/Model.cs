using System.Diagnostics;

namespace PD1;



class Model
{
   
    public string GetPath()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.txt";

        return projectDirectory.Replace("\\", "/");
    }
    public void SendMessgWrite()
    {
        Console.WriteLine("Write in File:"); 
    }
    public void SendMessgRead()
    {
        Console.WriteLine("Read from File:"); 
    }
    
};
