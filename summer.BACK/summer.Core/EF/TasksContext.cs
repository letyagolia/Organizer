using Microsoft.EntityFrameworkCore;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Core.EF
{
    public class TasksContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Note> Notes { get; set; }
        
        public TasksContext(DbContextOptions<TasksContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>()
                .HasOne(c => c.Category)
                .WithMany(cp => cp.Folders)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Note>()
                .HasOne(c => c.Folder)
                .WithMany(cp => cp.Notes)
                .HasForeignKey(c => c.FolderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
