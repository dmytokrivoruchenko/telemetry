using Microsoft.EntityFrameworkCore;
using SmartOffice.DAL.Interfaces;
using SmartOffice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOffice.DAL.Contexts
{
    public partial class TelemetryContext : DbContext, ITelemetryContext
    {
        public virtual DbSet<Indicator> Indicator { get; set; }

        public static string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Indicator>(entity =>
            {
                entity.ToTable("INDICATOR");

                entity.Property(e => e.Indicatorid).HasColumnName("INDICATORID");

                entity.Property(e => e.Dateandtime)
                    .HasColumnName("DATEANDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Humidity).HasColumnName("HUMIDITY");

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnName("ROOM")
                    .HasMaxLength(255);

                entity.Property(e => e.Temperature).HasColumnName("TEMPERATURE");
            });
        }
    }
}
