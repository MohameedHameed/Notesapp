using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Model
{
    public class Autor
    {
        [Key]
        public int AuthorId { get; set; }
        public  string AuthorName { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }

}

