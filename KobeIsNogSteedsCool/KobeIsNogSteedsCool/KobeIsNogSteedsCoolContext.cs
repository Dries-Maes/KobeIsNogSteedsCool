using KobeIsNogSteedsCool.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Xamarin.Essentials;

namespace KobeIsNogSteedsCool
    {
    internal class KobeIsNogSteedsCoolContext : DbContext
        {
        public DbSet<Note> Notes { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        public KobeIsNogSteedsCoolContext()
            {
            Database.EnsureCreated();
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "HowYouDoin.Ward");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
            }
        }
    }