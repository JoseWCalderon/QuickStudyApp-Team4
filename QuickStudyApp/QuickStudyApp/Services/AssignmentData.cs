using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using SQLite;
using QuickStudyApp.Models;
namespace QuickStudyApp.Services
{

    public class AssignmentData 
    {
        readonly SQLiteAsyncConnection _database;

        public AssignmentData(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<AssignmentDataControl>().Wait();
        }

        public Task<List<AssignmentDataControl>> GetNotesAsync()
        {
            return _database.Table<AssignmentDataControl>().ToListAsync();
        }

        public Task<AssignmentDataControl> GetNoteAsync(int id)
        {
            return _database.Table<AssignmentDataControl>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(AssignmentDataControl note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(AssignmentDataControl note)
        {
            return _database.DeleteAsync(note);
        }
    }
}