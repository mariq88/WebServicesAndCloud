using System;
using System.Data.Entity;
using Catalog.Model;

namespace Catalog.Data
{
    public class MusikContext : DbContext
    {
        public MusikContext()
            : base("MusikDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().Property(x => x.Name).HasMaxLength(150);
            modelBuilder.Entity<Artist>().Property(x => x.Country).IsOptional();
            modelBuilder.Entity<Artist>().Property(x => x.Country).HasMaxLength(100);
            modelBuilder.Entity<Artist>().Property(x => x.BirthDate).IsOptional();
            modelBuilder.Entity<Album>().Property(x => x.Title).HasMaxLength(150);
            modelBuilder.Entity<Album>().Property(x => x.ReleaseDate).IsOptional();
            modelBuilder.Entity<Album>().Property(x => x.Producer).IsOptional();
            modelBuilder.Entity<Album>().Property(x => x.Producer).HasMaxLength(100);
            modelBuilder.Entity<Song>().Property(x => x.Title).HasMaxLength(150);
            modelBuilder.Entity<Song>().Property(x => x.CreatingYear).IsOptional();
            modelBuilder.Entity<Song>().Property(x => x.CreatingYear).HasMaxLength(10);
            modelBuilder.Entity<Song>().Property(x => x.Ganre).IsOptional();

            base.OnModelCreating(modelBuilder);
        }
    }
}