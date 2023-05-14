using Microsoft.EntityFrameworkCore;
using FestivalHue.Dto;

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
        public DbSet<ProgramType> ProgramTypes { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<TicketLocation> TicketLocations { get; set; }
        public DbSet<FavouriteProgram> FavouritePrograms { get; set; }
        public DbSet<FavouriteService> FavouriteServices { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checkin>()
                .HasKey(c => new { c.AdminId, c.TicketId });
            modelBuilder.Entity<FavouriteProgram>()
                .HasKey(c => new { c.UserId, c.ProgramId });
            modelBuilder.Entity<FavouriteService>()
               .HasKey(c => new { c.UserId, c.ServiceId });
            modelBuilder.Entity<Notification>()
               .HasKey(c => new { c.UserId, c.ProgramId });
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Role)
                .WithMany(r => r.Admins)
                .HasForeignKey(a => a.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Role>()
                .HasMany(r => r.Admins)
                .WithOne(a => a.Role)
                .HasForeignKey(a => a.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Programm>()
                .HasOne(p => p.Admin)
                .WithMany(a => a.Programms)
                .HasForeignKey(p => p.AdminId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Admin>()
               .HasMany(r => r.Programms)
               .WithOne(a => a.Admin)
               .HasForeignKey(a => a.AdminId)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Programm>()
               .HasOne(p => p.Group)
               .WithMany(a => a.Programms)
               .HasForeignKey(p => p.GroupId)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Group>()
               .HasMany(r => r.Programms)
               .WithOne(a => a.Group)
               .HasForeignKey(a => a.GroupId)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Programm>()
             .HasOne(p => p.Location)
             .WithMany(a => a.Programms)
             .HasForeignKey(p => p.LocationId)
             .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Location>()
               .HasMany(r => r.Programms)
               .WithOne(a => a.Location)
               .HasForeignKey(a => a.LocationId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
            .HasOne(p => p.TicketType)
            .WithMany(a => a.Tickets)
            .HasForeignKey(p => p.TicketTypeId)
            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<TicketType>()
               .HasMany(r => r.Tickets)
               .WithOne(a => a.TicketType)
               .HasForeignKey(a => a.TicketTypeId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
                .HasOne(p => p.User)
                .WithMany(a => a.Tickets)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(r => r.Tickets)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
     
            modelBuilder.Entity<FavouriteProgram>()
                 .HasOne(p => p.User)
                 .WithMany(a => a.FavouritePrograms)
                 .HasForeignKey(p => p.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>()
                .HasMany(r => r.FavouritePrograms)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<FavouriteProgram>()
                 .HasOne(p => p.Programm)
                 .WithMany(a => a.FavouritePrograms)
                 .HasForeignKey(p => p.ProgramId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Programm>()
                .HasMany(r => r.FavouritePrograms)
                .WithOne(a => a.Programm)
                .HasForeignKey(a => a.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(r => r.FavouriteServices)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Service>()
                .HasMany(r => r.FavouriteServices)
                .WithOne(a => a.Service)
                .HasForeignKey(a => a.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notification>()
                 .HasOne(p => p.User)
                 .WithMany(a => a.Notifications)
                 .HasForeignKey(p => p.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>()
                .HasMany(r => r.Notifications)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Notification>()
                .HasOne(p => p.Programm)
                .WithMany(a => a.Notifications)
                .HasForeignKey(p => p.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Programm>()
                .HasMany(r => r.Notifications)
                .WithOne(a => a.Programm)
                .HasForeignKey(a => a.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Checkin>()
                .HasOne(p => p.Ticket)
                .WithMany(a => a.Checkins)
                .HasForeignKey(p => p.TicketId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ticket>()
                .HasMany(r => r.Checkins)
                .WithOne(a => a.Ticket)
                .HasForeignKey(a => a.TicketId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Checkin>()
               .HasOne(p => p.Admin)
               .WithMany(a => a.Checkins)
               .HasForeignKey(p => p.AdminId)
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Admin>()
                .HasMany(r => r.Checkins)
                .WithOne(a => a.Admin)
                .HasForeignKey(a => a.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Programm>()
               .HasOne(a => a.ProgramType) 
               .WithMany(r => r.Programms)
               .HasForeignKey(a => a.Type_program)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProgramType>()
                .HasMany(r => r.Programms)
                .WithOne(a => a.ProgramType)
                .HasForeignKey(a => a.Type_program)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Admin>()
               .HasOne(a => a.Role)
               .WithMany(r => r.Admins)
               .HasForeignKey(a => a.RoleId)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Role>()
                .HasMany(r => r.Admins)
                .WithOne(a => a.Role)
                .HasForeignKey(a => a.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
        }    
    }
}
