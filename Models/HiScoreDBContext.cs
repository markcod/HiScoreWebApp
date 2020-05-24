using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HiScoreWebApp.Models
{
    public partial class HiScoreDBContext : DbContext
    {
        public HiScoreDBContext()
        {
        }

        public HiScoreDBContext(DbContextOptions<HiScoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HiScore> HiScore { get; set; }
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HiScore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternavn)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fornavn)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
