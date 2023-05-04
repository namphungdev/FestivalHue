using Microsoft.EntityFrameworkCore;

namespace FestivalHue.Models
{
    public class FestivalHueContext : DbContext
    {
        public FestivalHueContext(DbContextOptions<FestivalHueContext> options) : base(options) { }
        #region DbSet
        public DbSet<Role> Roles { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<SubMenu> SubMenu { get; set; }
        public DbSet<TicketLocation> TicketLocation { get; set; }
        public DbSet<FavouriteProgram> FavouriteProgram { get; set; }
        public DbSet<FavouriteService> FavouriteService { get; set; }
        public DbSet<Notification> Notification { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checkin>()
                .HasKey(c => new { c.TicketId, c.UserId });
            modelBuilder.Entity<FavouriteProgram>()
               .HasKey(c => new { c.UserId, c.ProgramId });
            modelBuilder.Entity<FavouriteService>()
              .HasKey(c => new { c.UserId, c.ServiceId });
            modelBuilder.Entity<Notification>()
             .HasKey(c => new { c.UserId, c.ProgramId });
        }


    }
}
