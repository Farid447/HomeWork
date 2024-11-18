namespace EF_Core.Models;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;

    //public ICollection<Baskets> Basket { get; set; }

}
