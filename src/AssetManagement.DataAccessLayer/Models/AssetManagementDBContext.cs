using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AssetManagement.DataAccessLayer.Models
{
    public partial class AssetManagementDBContext : DbContext
    {
        public AssetManagementDBContext()
        {
        }

        public AssetManagementDBContext(DbContextOptions<AssetManagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SchemeInfo> SchemeInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AssetManagementDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchemeInfo>(entity =>
            {
                entity.HasKey(e => e.SchemeCode)
                    .HasName("PK__SchemeIn__8B17EDD4C8AF34BA");

                entity.ToTable("SchemeInfo");

                entity.Property(e => e.SchemeCode).ValueGeneratedNever();

                entity.Property(e => e.Amc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMC");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.NetAssetValue)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SchemeName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
