using FSDHAPi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHAPi.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
         : base(options)
        {


        }

        public virtual DbSet<TblRequestandResponseLog> tblRequestandResponseLog { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TblRequestandResponseLog>(entity =>
            {

                entity.ToTable("tblRequestAndResponses");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.RequestType).IsRequired(true).IsUnicode(false).HasMaxLength(100);
                entity.Property(e => e.RequestPayload).IsRequired(true).IsUnicode(true).HasMaxLength(5000);
                entity.Property(e => e.RequestId).IsRequired(false).IsUnicode(false).HasMaxLength(50);
                entity.Property(e => e.Response).IsRequired(false).IsUnicode(true).HasMaxLength(int.MaxValue);
                entity.Property(e => e.RequestTimestamp).IsRequired(true).HasColumnType("datetime");
                entity.Property(e => e.ResponseTimestamp).IsRequired(true).HasColumnType("datetime");
                entity.Property(e => e.RequestBaseUrl).IsRequired(true).IsUnicode(true).HasMaxLength(int.MaxValue);
                entity.Property(e => e.RequestEndpoint).IsRequired(true).IsUnicode(true).HasMaxLength(int.MaxValue);

            });

        }
    }
}
