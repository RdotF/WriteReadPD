namespace WriteReadPD.Services;

public class Path
{
    public string GetPath()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.txt";

        return projectDirectory.Replace("\\", "/");
    }
}