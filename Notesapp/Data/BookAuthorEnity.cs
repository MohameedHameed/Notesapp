using Microsoft.EntityFrameworkCore;
using Notesapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Data
{
    internal class BookAuthorEnity : IDataHelper<BookAuthor>
    {
        public DBContext db;
        public BookAuthorEnity()
        {
            db = new DBContext();
        }
        public async Task<string> AddDataAsync(BookAuthor table)
        {
            try
            {
                await db.BookAuthors.AddAsync(table);
                await db.SaveChangesAsync();
                return "sucess";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task DeleteDataAsync(BookAuthor table)
        {
            db.BookAuthors.Remove(table);
            await db.SaveChangesAsync();
        }

        public async Task<BookAuthor> FindAsync(int Id)
        {
            return await db.BookAuthors.FindAsync(Id);
        }

        public async Task<List<BookAuthor>> GetAllAsync()
        {
            return await db.BookAuthors.ToListAsync();
        }

        public async Task UpdateDataAsync(BookAuthor table)
        {
            db = new DBContext();
            db.BookAuthors.Update(table);
            await db.SaveChangesAsync();

        }
    }
}
