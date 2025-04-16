using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public ICollection<Autor> Authors { get; set; } = new List<Autor>();
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}
