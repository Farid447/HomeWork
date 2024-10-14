namespace ClassProdukt
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Produkt corek = new Produkt("UnMehsulu", "LezgiCoreyi", 1.20);
            Produkt icki = new Produkt("Araq", "Samaqon", 19.99);
            Produkt kofe = new Produkt("Qehve", "Nescafe", 10);
            Produkt pesok = new Produkt("SekerTozu", "AzerSeker", 5);
            Produkt asvijitel = new Produkt("AirWick", "Glade", 13.6);

            Produkt[] produkts = { pesok, kofe, icki, asvijitel, corek};
            
            double ucuz = double.Parse(Console.ReadLine());
            double baha = double.Parse(Console.ReadLine());
            
            Qenaet(produkts, ucuz, baha);

        }
        static void Qenaet(Produkt[] products, double ucuz, double baha)
        {
        bool tapildi = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (ucuz < products[i].qiymet && products[i].qiymet < baha)
                {
                    Console.WriteLine(products[i].brendad + " " + products[i].qiymet);
                    tapildi = true;
                }
            }
            if (!tapildi)
            {
                Console.WriteLine("Mehsul tapilmadi!");
            }
        }
    }
}
