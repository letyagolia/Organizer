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
    }
}
