using FrontToBack.Models;
using FrontToBack.Models.About;
using FrontToBack.Models.Contact;
using FrontToBack.Models.Pricing;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FrontToBack.Data
{
    public class AppDbContext : DbContext
    {
        internal IEnumerable<object> sliders;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderBackground> SliderBackgrounds { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
