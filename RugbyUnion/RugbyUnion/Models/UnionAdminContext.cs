using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyUnion.Models
{

        public class UnionAdminContext : DbContext
        {
            public virtual DbSet<UnionAdmin> Userdetails { get; set; }

            public DbSet<Team> Teams { get; set; }
            public DbSet<Player> Players { get; set; }
        public UnionAdminContext(DbContextOptions<UnionAdminContext> options) : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<UnionAdmin>(entity =>
                {
                    entity.ToTable("UnionAdmin");

                    entity.Property(e => e.Email)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    //entity.Property(e => e.Mobile)
                    //    .HasMaxLength(50)
                    //    .IsUnicode(false);

                    entity.Property(e => e.AdminName)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Password)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });
            }

        }
    }

