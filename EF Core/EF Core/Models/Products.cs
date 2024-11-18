namespace EF_Core.Models;

public class Products
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }

    //public ICollection<Baskets> Basket { get; set; }

}