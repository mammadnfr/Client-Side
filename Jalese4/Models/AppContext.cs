using Microsoft.EntityFrameworkCore;

namespace Jalese4.Models
{
    public class MydbCon : DbContext
    {
        public MydbCon(DbContextOptions<MydbCon> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }


    }
}