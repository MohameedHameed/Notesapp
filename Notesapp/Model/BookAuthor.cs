using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Model
{
    public class BookAuthor
    {
        [Key]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Key]
        public int AuthorId { get; set; }
        public Autor Author { get; set; }
    }
}
