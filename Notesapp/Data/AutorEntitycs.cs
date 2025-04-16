using Microsoft.EntityFrameworkCore;
using Notesapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesapp.Data { }
/*{
    internal class AutorEntity: IDataHelper<Autor>
    {
        public DBContext db;
        public AutorEntity()
        {
            db = new DBContext();
        }
      public async Task<bool> AddDataAsync(Autor table)
        {
            try
            {
                await db.Autors.AddAsync(table);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        public async Task DeleteDataAsync(Autor table)
        {
            db.Autors.Remove(table);
            await db.SaveChangesAsync();
        }

        public async Task<Autor> FindAsync(int Id)
        {
            return await db.Autors.FindAsync(Id);
        }

        public async Task<List<Autor>> GetAllAsync()
        {
            return await db.Autors.ToListAsync();
        }

        public async Task UpdateDataAsync(Autor table)
        {
            db = new DBContext();
            db.Autors.Update(table);
            await db.SaveChangesAsync();

        }
    }
}
*/