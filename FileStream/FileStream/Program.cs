namespace FileStream;
internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\Farid\Desktop\FileStream\FileStream\names.json";
        FileHelper help = new(path);

        help.Add("murad");
        help.Add("ferid");

        help.Delete(0);
        help.Update(1, "revan");
        Console.WriteLine(help.Exist("huseyn"));
        //help.Exist("revan");
    }
}
