using BMModel;
using BMModel.Areas;
using BMModel.Categories;
using BMModel.Personals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
         
        }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Kind> Kind { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Receiver> Receiver { get; set; }
        public DbSet<Sender> Sender { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
        public DbSet<Advertise> Advertise { get; set; }
    }
}
