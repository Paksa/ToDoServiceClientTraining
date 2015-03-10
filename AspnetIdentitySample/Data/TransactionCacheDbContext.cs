using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoManager.Models;

namespace ToDoManager.Data
{
    public class TransactionCacheDbContext : DbContext
    {
        public TransactionCacheDbContext()
            : base("TransactionCacheDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TransactionCacheDbContext>());
        }
        public virtual DbSet<ToDoModel> Todos { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }

        public virtual DbSet<ToDoItemLocal> TodoChanges { get; set; }
    }
}