using TextEditor.Interfaces;

namespace TextEditor;

internal class NotePad : ITextEditor
{
    private string _filename;
    private string _currenttext;
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
        Console.WriteLine("C:/Users/Desktop/" + _filename + ".txt");
    }

    public void Write(string text)
    {
        _currenttext += text;
    }
}
