using eTicket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movies).
                WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actors).
                WithMany(am => am.Actors_Movies).HasForeignKey(a=> a.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

    }
}
