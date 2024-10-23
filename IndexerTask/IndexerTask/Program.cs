namespace IndexerTask;

internal class Program
{
    static void Main(string[] args)
    {
        ListInt obj = new ListInt();
        obj.Add(1);
        obj.Add(2);
        obj.Add(3);
        obj.Add(4);
        obj.Add(0);
        //obj[6] = 4;
        Console.WriteLine(obj);
    }
}