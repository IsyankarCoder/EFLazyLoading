using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFLazyLoading
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  ICollection<Book> Books { get; set; }
        
    }

    public class Book
    {
         public int Id { get; set; }
         public string Title { get; set; }
         public int AuthorId { get; set; }

         [ForeignKey(nameof(AuthorId))]
         public  Author Author { get; set; }
    }
}
