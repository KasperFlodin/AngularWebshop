using System.Net;
using System.Numerics;

namespace APIWebshop.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Peter",
                    LastName = "Lund",
                    Phone = "12345678",
                    Address = "Meterskoven 1",
                    City = "Byen",
                    Zip = "4321",
                    Email = "Peter.lund@gmail.com",
                    Password = "123456",
                    Role = Role.Admin,
                },
                new User
                {
                    Id = 2,
                    FirstName = "Simon",
                    LastName = "Green",
                    Phone = "11223344",
                    Address = "Skoven 2",
                    City = "Tarn",
                    Zip = "1144",
                    Email = "Simon.green@gmail.com",
                    Password = "123456",
                    Role = Role.User,
                });

            // Car products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "S200",
                    Price = 3000,
                    Type = "Bed"
                },
                 new Product
                 {
                     Id = 2,
                     Name = "WoodTable",
                     Price = 1200,
                     Type = "Table"
                 },
                  new Product
                  {
                      Id = 3,
                      Name = "WoodChair",
                      Price = 299,
                      Type = "Chair"
                  },
                   new Product
                   {
                       Id = 4,
                       Name = "PlasticChair",
                       Price = 99,
                       Type = "Chair"
                   },
                    new Product
                    {
                        Id = 5,
                        Name = "Sleepr",
                        Price = 5000,
                        Type = "Bed"
                    },
                     new Product
                     {
                         Id = 6,
                         Name = "z00",
                         Price = 600,
                         Type = "Fence"
                     });
        }
    }
}
