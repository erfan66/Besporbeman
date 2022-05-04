using BMModel;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
         
        }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Origin> Origin { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Kind> Kind { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Advertise> Advertise { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
