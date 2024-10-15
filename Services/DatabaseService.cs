using Notify.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notify.Services
{
    class DatabaseService
    {
        SQLiteAsyncConnection Database;

        async Task Init()
        {
            //Creates Database table for all Notes. Notes will have properties that sort them into respective folders when that feature is implemented.
            if (null != Database) { return; }
            string dbFileName = "EntryDatabase.db3";
            string DatabasePath = Path.Combine(FileSystem.AppDataDirectory, dbFileName);
            SQLiteOpenFlags Flags = SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache;
            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            var result = await Database.CreateTableAsync<Note>();
        }

        public async static Task AddNoteAsync(Note NewNote)
        {

        }
    }
}
