namespace PD1.Interfaces;

public interface IWrite
{
    public Task WriteFile(string text, string path);
}