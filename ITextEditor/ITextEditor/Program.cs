using TextEditor.Interfaces;

namespace TextEditor;

internal class Program
{
    static void Main(string[] args)
    {
        Word document = new Word();
        NotePad document2 = new NotePad();
        WordPad document3 = new WordPad();

        ITextEditor file = document;
        ITextEditor file2 = document;
        ITextEditor file3 = document;
        
        document.Write("svfa");
        file.Save();
        document.Save();
    }
}
