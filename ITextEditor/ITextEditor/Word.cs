using TextEditor.Interfaces;

namespace TextEditor;

internal class Word : ITextEditor
{
    private string _currenttext;
    private string _filename;

    public string currenttext { get { return _currenttext; } }

    public void Open()
    {
        _currenttext = "";
    }

    public void Save()
    {
        Console.WriteLine("file save edildi: " + currenttext);
    }

    public void SaveAndClose()
    {
        Console.WriteLine("file adi daxil edin: ");
        _filename = Console.ReadLine();
        Console.WriteLine("C:/Users/Word/" + _filename + ".docx");
    }

    public void Write(string text)
    {
        _currenttext += text;
    }
}
