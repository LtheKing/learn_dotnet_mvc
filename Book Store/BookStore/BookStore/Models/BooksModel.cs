using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BooksModel
    {
        public int ID { get; set; }
        public string BooksName { get; set; }
        public int AuthorID { get; set; }
        public int Price { get; set; }
    }
}
