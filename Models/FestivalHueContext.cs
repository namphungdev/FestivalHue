using Microsoft.EntityFrameworkCore;

namespace FestivalHue.Models
{
    public class FestivalHueContext : DbContext
    {
        public FestivalHueContext(DbContextOptions<FestivalHueContext> options) : base(options) { }
        public DbSet<Role> Roles { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Checkin> Checkins { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<Programm> Programms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<TicketLocation> TicketLocations { get; set; }
        public DbSet<FavouriteProgram> FavouritePrograms { get; set; }
        public DbSet<FavouriteService> FavouriteServices { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checkin>()
                .HasKey(c => new { c.TicketId, c.AdminId });
            modelBuilder.Entity<FavouriteProgram>()
                .HasKey(c => new { c.UserId, c.ProgramId });
            modelBuilder.Entity<FavouriteService>()
               .HasKey(c => new { c.UserId, c.ServiceId });
            modelBuilder.Entity<Notification>()
               .HasKey(c => new { c.UserId, c.ProgramId });
        }
    }
}
