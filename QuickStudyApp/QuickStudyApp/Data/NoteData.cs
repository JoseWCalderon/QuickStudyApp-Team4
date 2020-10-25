using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using PCLStorage;
using SQLite;
using QuickStudyApp.Models;
namespace QuickStudyApp.Services
{

    public class NoteDatabase
    {

        readonly SQLiteAsyncConnection _database;



        public NoteDatabase(string dbPath)

        {

            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<NoteDataControl>().Wait();

        }



        public Task<List<NoteDataControl>> GetNotesAsync()

        {

            return _database.Table<NoteDataControl>().ToListAsync();

        }



        public Task<NoteDataControl> GetNoteAsync(int id)

        {

            return _database.Table<NoteDataControl>()

                            .Where(i => i.ID == id)

                            .FirstOrDefaultAsync();

        }



        public Task<int> SaveNoteAsync(NoteDataControl note)

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



        public Task<int> DeleteNoteAsync(NoteDataControl note)

        {

            return _database.DeleteAsync(note);

        }

    }
}