using System;
using System.Linq;
using System.Data.Entity;


namespace EFLazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                var author = context.Authors.Select(x => new { b = x.Books.AsQueryable().Select(c => c.Title).ToList() });

                foreach (var b in author.b)
                    Console.WriteLine(b.Title);
            }

            Console.ReadLine();
        }
    }
}
