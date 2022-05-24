using DrywallModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallDB.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<WallType> WallTypes { get; set; }
        



        //FluentSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WallType>()
                .HasKey(t => t.Id);
                
            modelBuilder.Entity<WallType>()
                .Property(w=>w.Name)
                .HasMaxLength(2)
                .IsRequired();

            modelBuilder.Entity<WallType>()
                .Property(w => w.Width)
                .IsRequired()
                .HasDefaultValue(0.05);

            modelBuilder.Entity<WallType>()
                .Property(w => w.Height)
                .IsRequired();

            modelBuilder.Entity<WallType>()
                .Property(w => w.FirstLayer)
                .IsRequired();
            modelBuilder.Entity<WallType>()
                .Property(w=>w.SecondLayer)
                .IsRequired(false);


            



        }
    }
}
