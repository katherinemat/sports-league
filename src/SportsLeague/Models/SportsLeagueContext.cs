using Microsoft.EntityFrameworkCore;

namespace SportsLeague.Models
{
    public class SportsLeagueContext : DbContext
    {
        
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SportsLeague;integrated security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DivisionTeam>()
           .HasKey(t => new { t.DivisionId, t.TeamId });

            modelBuilder.Entity<DivisionTeam>()
                .HasOne(pt => pt.Division)
                .WithMany(p => p.DivisionTeams)
                .HasForeignKey(pt => pt.DivisionId);

            modelBuilder.Entity<DivisionTeam>()
                .HasOne(pt => pt.Team)
                .WithMany(t => t.DivisionTeams)
                .HasForeignKey(pt => pt.TeamId);
        }
    }
}