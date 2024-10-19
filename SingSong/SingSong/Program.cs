namespace SingSong;

internal class Program
{
    static void Main(string[] args)
    {
        Singer MuslumMaqomayev = new Singer("Muslum", "Maqomayev", 66);
        Song Azerbaycan = new Song("Azerbaycan", "Pop", MuslumMaqomayev);

        Azerbaycan.AddRating(5.5);
        Azerbaycan.AddRating(6.5);
        Azerbaycan.AddRating(0);
        Azerbaycan.AddRating(10);

        Console.WriteLine(Azerbaycan.GetAverageRating());
    }
}
