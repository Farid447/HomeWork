namespace SingSong;

internal class Singer
{
    private string _name;
    private string _surname;
    private int _age;

    public Singer(string name, string surname, int age)
    {
        Name = name;
		Surname = surname;
		Age = age;
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
				else {
                    Console.WriteLine("name 100 herfden az olmalidir, yeniden daxil edin");
                    value = Console.ReadLine();
                }
            }
        }
    }

	public string Surname
	{
		get { return _surname; }
		set
		{
			while (true)
			{
				if (0 < value.Length && value.Length <= 100)
				{
					_surname = value;
					break;
				}
                else
                {
                    Console.WriteLine("surname 100 herfden az olmalidir, yeniden daxil edin");
                    value = Console.ReadLine();
                }
            }
		}
	}

	public int Age
	{
		get { return _age; }
		set { 
			while (true)
			{
				if (0 < value && value <= 170)
				{
					_age = value;
					break;
				}
				else
				{
                    Console.WriteLine("yasi yanlis daxil etdiniz, yeniden daxil edin");
					value = Int16.Parse(Console.ReadLine());
                }
            }
		}
	}
}