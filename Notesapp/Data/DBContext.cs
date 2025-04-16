using Microsoft.EntityFrameworkCore;
using Notesapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Data
{
    internal class DBContext:DbContext
    {
        //add tables
        public DbSet<Note> Notes { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filename = Path.Combine(path, "AppdbNote.db");
            optionsBuilder.UseSqlite("FileName="+filename);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                            .HasMany(b => b.Authors)
                            .WithMany(a => a.Books)
                            .UsingEntity<BookAuthor>(
                                j => j
                                    .HasOne(ba => ba.Author)
                                    .WithMany(a => a.BookAuthors)
                                    .HasForeignKey(ba => ba.AuthorId),
                                j => j
                                    .HasOne(ba => ba.Book)
                                    .WithMany(b => b.BookAuthors)
                                    .HasForeignKey(ba => ba.BookId),
                                j =>
                                {
                                    j.HasKey(ba => new { ba.BookId, ba.AuthorId });
                                });

            // Seed data
            modelBuilder.Entity<Autor>().HasData(
                new Autor { AuthorId = 1, AuthorName = "Author 1" },
                new Autor { AuthorId = 2, AuthorName = "Author 2" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Book 1" },
                new Book { BookId = 2, Title = "Book 2" }
            );
        }

    }

    }

