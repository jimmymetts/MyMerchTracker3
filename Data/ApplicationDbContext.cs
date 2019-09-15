using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMerchTracker3.Models;

namespace MyMerchTracker3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<ApplicationUser> ApplicationUser { get; set; }
         public DbSet<MyMerchTracker3.Models.Merch> Merch { get; set; }
         public DbSet<MyMerchTracker3.Models.MerchType> MerchType { get; set; }
         
    }
}

