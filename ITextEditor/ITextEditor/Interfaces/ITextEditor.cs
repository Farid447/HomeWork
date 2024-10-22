namespace TextEditor.Interfaces;

interface ITextEditor
{
    public string currenttext { get; }
    void Open();
    void Write(string text);
    void Save();
    void SaveAndClose();
}