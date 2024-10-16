using Notify.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Notify.Services
{
    class DatabaseService
    {
        static SQLiteAsyncConnection Database;

        public static async Task Init()
        {
            //Creates Database table for all Notes. Notes will have properties that sort them into respective folders when that feature is implemented.
            if (Database != null) { return; }
            string dbFileName = "EntryDatabase.db3";
            string DatabasePath = Path.Combine(FileSystem.AppDataDirectory, dbFileName);
            SQLiteOpenFlags Flags = SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache;
            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            var _ = await Database.CreateTableAsync<Note>();
        }

        public static async Task GetNotesAsync()
        {
            await Init();
            await Database.Table<Note>().ToListAsync();
        }

        public static async Task ClearNotesAsync()
        {
            await Init();
            await Database.DeleteAllAsync<Note>();
        }

        public static async Task AddNoteAsync(Note NewNote)
        {
            await Init();
            await Database.InsertAsync(NewNote);
        }

        public static async Task DeleteNoteAsync(Note NoteToDelete)
        {
            await Init();
            await Database.DeleteAsync(NoteToDelete);
        }
    }
}
