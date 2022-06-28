using Microsoft.EntityFrameworkCore;
using System;

namespace KolokwiumRemastered.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {
        }
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<File> File { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Membership> Membership { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<File>(f =>
            {
                f.HasKey(e => e.FileID);
                f.Property(e => e.FileSize).IsRequired();
                f.Property(e => e.TeamID).IsRequired();
                f.Property(e => e.FileExtension).IsRequired();
                f.Property(e => e.FileName).IsRequired();

                f.HasData(
                    new File { FileID = 1, FileName = "File1", FileExtension = ".json", FileSize = 1000, TeamID = 1},
                    new File { FileID = 2, FileName = "File2", FileExtension = ".txt", FileSize = 2000, TeamID = 2 }
                    );
            });
            modelBuilder.Entity<Member>(m =>
            {
                m.HasKey(e => e.MemberID);
                m.Property(e => e.OrganizationID).IsRequired();
                m.Property(e => e.MemberName).IsRequired().HasMaxLength(20);
                m.Property(e => e.MemberSurname).IsRequired().HasMaxLength(50);
                m.Property(e => e.MemberNickName).IsRequired().HasMaxLength(20);

                m.HasData(
                    new Member { MemberID = 1, OrganizationID = 1, MemberName = "Jan", MemberSurname= "Kowalski", MemberNickName = "JaKowa"},
                    new Member { MemberID = 2, OrganizationID = 2, MemberName = "Adam", MemberSurname= "Nowak", MemberNickName = "AdaNo"}
                    );

            });
            modelBuilder.Entity<Organization>(o =>
            {
                o.HasKey(e => e.OrganizationID);
                o.Property(e => e.OrganizationName).IsRequired().HasMaxLength(100);
                o.Property(e => e.OrganizationDomain).IsRequired().HasMaxLength(50);

                o.HasData(new Organization { OrganizationID = 1, OrganizationName = "Organization1", OrganizationDomain = "Domain 1" },
                          new Organization { OrganizationID = 2, OrganizationName = "Organization2", OrganizationDomain = "Domain 2"});

             

            });
            modelBuilder.Entity<Membership>(m =>
            {
                m.HasKey(e => new { e.MemberID, e.TeamID});
                m.Property(e => e.MembershipDate).IsRequired();

                m.HasData(new Membership { MemberID = 1, TeamID = 1, MembershipDate = DateTime.Parse("2022-01-01") },
                          new Membership { MemberID = 2, TeamID =2, MembershipDate = DateTime.Parse("2022-02-02")
                          });
                

            });
            modelBuilder.Entity<Team>(t =>
            {
                t.HasKey(e => e.TeamID);
                t.Property(e => e.OrganizationID).IsRequired();
                t.Property(e => e.TeamName).IsRequired().HasMaxLength(50);
                t.Property(e => e.TeamDescription).IsRequired().HasMaxLength(500);

            });

        }
    }
}
