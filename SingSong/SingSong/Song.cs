namespace SingSong;

internal class Song
{
    private string _name;
    private string _genre;
    private Singer _singer;
    private double[] _ratings = new double[0];

    public Song(string name, string genre, Singer singer)
    {
        Name = name;
        Genre = genre;
        Singer = singer;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            while (true)
            {
                if (0 < value.Length && value.Length <= 100)
                {
                    _name = value;
                    break;
                }
                else
                {
                    Console.WriteLine("name 100 herfden az olmalidir, yeniden daxil edin");
                    value = Console.ReadLine();
                }
            }
        }
    }
    public string Genre
    {
        get { return _genre; }
        set
        {
            while (true)
            {
                if (value == "Techno" || value == "Jazz" || value == "Pop" || value == "Rock")
                {
                    _name = value;
                    break;
                }
                else
                {
                    Console.WriteLine("duzgun daxil etmediniz, yeniden daxil edin");
                    value = Console.ReadLine();
                }
            }
        }
    }

    public Singer Singer
    {
        get { return _singer; }
        set { _singer = value; }
    }

    public void AddRating(double rating)
    {
        Array.Resize(ref _ratings, _ratings.Length + 1);
        _ratings[_ratings.Length - 1] = rating;
    }

    public double GetAverageRating()
    {
        double averageRating = 0;
        for (int i = 0; i < _ratings.Length; i++)
        {
            averageRating += _ratings[i];
        }
        return averageRating / _ratings.Length;
    }
}