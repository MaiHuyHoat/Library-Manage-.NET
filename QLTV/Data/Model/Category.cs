using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class Category
    {
        public Category()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Deleted { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
