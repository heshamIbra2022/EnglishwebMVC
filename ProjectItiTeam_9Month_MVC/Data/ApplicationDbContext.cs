﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectItiTeam.Models;
using ProjectItiTeam.Models.Identity;
using ProjectItiTeam.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectItiTeam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=DESKTOP-354JS6L\\SQLEXPRESS;Initial catalog=projectTest_1 ;Integrated security = true");

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            base.OnModelCreating(builder);
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        public DbSet<Exam> Exams { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Level> levels { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Rate_Artical> Rate_Articals { get; set; }
        public DbSet<Audio> Audios { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<MCQ> MCQs { get; set; }
        public DbSet<choice> Choices { get; set; }
        public DbSet<Artical> Articals { get; set; }
        
        public DbSet<TrueAndFalse> TrueAndFalses { get; set; }
        public DbSet<Quiz> Quizzes  { get; set; }
public DbSet<Comment> comments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


    }
}
