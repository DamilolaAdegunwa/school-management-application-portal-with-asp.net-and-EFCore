using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SchoolManagementApplication.Core.Model;
using Microsoft.Extensions.Options;
using SchoolManagementApplication.Repository.Data.Entity;
using SchoolManagementApplication.Repository.Data.Entity.ExtendedEntity;

namespace SchoolManagementApplication.Repository.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        #region fields
        private readonly AppSettings _appSettings;
        #endregion
        #region DbSet (the point of connection between a class and the object representing the table created)
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        #endregion
        public ApplicationDbContext(IOptions<AppSettings> options)
        {
            this._appSettings = options.Value; 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_appSettings.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 1-1 mapping with Lecturer
            modelBuilder.Entity<Lecturer>()
            .HasOne(a => a.StaffAcount)
            .WithOne(b => b.Lecturer)
            .HasForeignKey<StaffAccount>(b => b.LecturerId);

            modelBuilder.Entity<Lecturer>()
            .HasOne(a => a.Person)
            .WithOne(b => b.Lecturer)
            .HasForeignKey<Person>(b => b.LecturerId);

            modelBuilder.Entity<Lecturer>()
            .HasOne(a => a.Medicals)
            .WithOne(b => b.Lecturer)
            .HasForeignKey<Medicals>(b => b.LecturerId);
            #endregion

            #region 1-1 mapping with NonTeachingStaff
            modelBuilder.Entity<NonTeachingStaff>()
            .HasOne(a => a.StaffAcount)
            .WithOne(b => b.NonTeachingStaff)
            .HasForeignKey<StaffAccount>(b => b.NonTeachingStaffId);

            modelBuilder.Entity<NonTeachingStaff>()
            .HasOne(a => a.Person)
            .WithOne(b => b.NonTeachingStaff)
            .HasForeignKey<Person>(b => b.NonTeachingStaffId);

            modelBuilder.Entity<NonTeachingStaff>()
            .HasOne(a => a.Medicals)
            .WithOne(b => b.NonTeachingStaff)
            .HasForeignKey<Medicals>(b => b.NonTeachingStaffId);
            #endregion
        }
    }
}