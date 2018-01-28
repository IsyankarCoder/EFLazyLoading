using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration;

namespace EFLazyLoading
{
    public class BookContext
        :DbContext
    {
        public  DbSet<Author> Authors { get; set; }
        public  DbSet<Book> Books { get; set; }
       
        public BookContext() 
            : base("BookContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookContext>());
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
