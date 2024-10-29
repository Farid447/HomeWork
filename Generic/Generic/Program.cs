using System.Collections.Specialized;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meat et = new Meat(220, MeatType.pismis);
            Console.WriteLine(et.Calorie);


            Elephant elephant = new Elephant(100, true, 80, Gender.arvad, "bala", 100);
            Wolf<Animal> wolf = new Wolf<Animal>(true, 100, 50, Gender.kiwi, "dagcanavari", 150);
            
            Console.WriteLine(elephant.HP);

            wolf.Hunt(elephant);
            Console.WriteLine(elephant.HP);

        }
    }
}
