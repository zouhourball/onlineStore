
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions option) : base(option)
        {

        }
        //property
        public DbSet<Product> Products { get; set; }
    }
}