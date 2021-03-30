using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteBackendWebMotors.Data.Entities;
using TesteBackendWebMotors.Data.Mapper;

namespace TesteBackendWebMotors.Data.DataContext
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Anuncio> Anuncios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AnuncioMapper().Configure(modelBuilder.Entity<Anuncio>());

        }
    }
}
