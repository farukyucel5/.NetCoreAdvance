using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SpecFlowDatabaseTesting.Entities;

namespace SpecFlowDatabaseTesting.DbContexts;

public partial class WorldContext : DbContext
{
    public WorldContext()
    {
    }

    public WorldContext(DbContextOptions<WorldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=world;Uid=root;Pwd=Faruk12068036");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PRIMARY");

            entity.ToTable("city");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .HasColumnName("city_name");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Turkey'")
                .HasColumnName("country");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("region");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
