using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
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

            _database.CreateTableAsync<NoteDataControlInformation>().Wait();

        }



        public Task<List<NoteDataControlInformation>> GetNotesAsync()

        {

            return _database.Table<NoteDataControlInformation>().ToListAsync();

        }



        public Task<NoteDataControlInformation> GetNoteAsync(int id)

        {

            return _database.Table<NoteDataControlInformation>()

                            .Where(i => i.ID == id)

                            .FirstOrDefaultAsync();

        }



        public Task<int> SaveNoteAsync(NoteDataControlInformation note)

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



        public Task<int> DeleteNoteAsync(NoteDataControlInformation note)

        {

            return _database.DeleteAsync(note);

        }

    }
}