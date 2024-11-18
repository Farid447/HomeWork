using EF_Core.Context;
using EF_Core.Exceptions;
using EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.ValueGeneration.Internal;
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EF_Core;

internal class Program
{
    static void Main(string[] args)
    {
        List<Baskets> baskets = [];
        List<Products> products = [];
        List<Users> users = [];

        using (DBContext sql = new DBContext())
        {
            

            while (true)
            {
                Console.WriteLine("1. Register\r\n2. Login");
                int digit = Convert.ToInt32(Console.ReadLine());

                switch (digit)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Name, Surname, Username, Password daxil edin");
                            string name = Console.ReadLine();
                            string surname = Console.ReadLine();
                            string username = Console.ReadLine();
                            string password = Console.ReadLine();

                            var nese = sql.Users.ToList().Find(x => x.Username == username);

                            if (nese is null)
                            {
                                sql.Users.Add(new Users
                                {
                                    Name = name,
                                    Surname = surname,
                                    Username = username,
                                    Password = password
                                });

                                sql.SaveChanges();
                                Console.WriteLine("Qeydiyyat ugurludur!");
                                break;

                            }
                            else
                            {
                                Console.WriteLine("bu username movcuddur");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Username, Password daxil edin");
                        string username2 = Console.ReadLine();
                        string password2 = Console.ReadLine();

                        var user = sql.Users.Where(x => x.Username == username2 && x.Password == password2).FirstOrDefault();

                        if (user is null)
                        {
                            //throw new UserNotFoundException("username ve ya kod sehvdir");
                            Console.WriteLine("username ve ya kod sehvdir");
                            break;
                        }

                        Console.WriteLine("hesaba daxil oldunuz");


                        bool istrue = true;
                        while (istrue)
                        {
                            Console.WriteLine("""
                            
                            0.Menu.
                            1.Mehsullara bax.
                            2.Sebete bax.
                            3.Hesabdan çix.
                            
                            """);
                            int eded = Convert.ToInt32(Console.ReadLine());
                            switch (eded)
                            {
                                case 0:
                                    break;
                                case 1:
                                    products = sql.Products.ToList();

                                    foreach (var prod in products)
                                    {
                                        Console.WriteLine(prod.Id + ". " + prod.Name + " - " + prod.Price + " AZN");

                                    }

                                    Console.WriteLine("sebetinize elave etmek istediyiniz mehsulun id-sini yazin");
                                    int reqem = int.Parse(Console.ReadLine());
                                    var product = sql.Products.Where(x => x.Id == reqem).FirstOrDefault();

                                    if (product is null)
                                    {
                                        //throw new ProductNotFoundException("bu mehsul bazada yoxdur");

                                        Console.WriteLine("bu mehsul bazada yoxdur");
                                        break;

                                    }
                                    sql.Baskets.Add(new Baskets
                                    {
                                        UserId = user.Id,
                                        ProductId = product.Id,
                                    });

                                    sql.SaveChanges();
                                    Console.WriteLine("mehsul sebete elave olundu");
                                    
                                    break;
                                case 2:
                                    baskets = sql.Baskets.Where(x => x.UserId == user.Id).ToList();

                                    foreach (var bask in baskets)
                                    {
                                        var product2 = sql.Products.Where(x => x.Id == bask.ProductId).FirstOrDefault();
                                        Console.WriteLine(product2.Id + ". " + product2.Name + " - " + product2.Price + " AZN");
                                    }

                                    Console.WriteLine("sebetden silmek istediyiniz mehsulun id-sini yazin:");
                                    int sil_Id = int.Parse(Console.ReadLine());

                                    var data = sql.Baskets.Where(x => x.UserId == user.Id &&  x.ProductId == sil_Id).FirstOrDefault();

                                    var data2 = baskets.Find(x => x.ProductId == sil_Id);

                                    if (data is null)
                                    {
                                        //throw new ProductNotFoundException("bele mehsul yoxdur");

                                        Console.WriteLine("bele mehsul yoxdur");
                                        break;
                                    }
                                    sql.Baskets.Remove(data);
                                    Console.WriteLine("mehsul silindi");
                                    sql.SaveChanges();
                                    
                                    break;
                                case 3:
                                    istrue = false;
                                    break;
                                default:
                                    Console.WriteLine("duzgun eded daxil etmediniz");
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("sehv eded daxil etdiniz");
                        break;
                }
            }
        }
    }
}
