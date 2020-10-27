using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using QuickStudyApp.Models;

namespace QuickStudyApp.Services
{
    public class ScheduleData
    {
        readonly SQLiteAsyncConnection _database;

        public ScheduleData(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ScheduleDataControl>().Wait();
        }

        public Task<List<ScheduleDataControl>> GetNotesAsync()
        {
            return _database.Table<ScheduleDataControl>().ToListAsync();
        }

        public Task<ScheduleDataControl> GetNoteAsync(int id)
        {
            return _database.Table<ScheduleDataControl>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(ScheduleDataControl note)
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

        public Task<int> DeleteNoteAsync(ScheduleDataControl note)
        {
            return _database.DeleteAsync(note);
        }
    }
}