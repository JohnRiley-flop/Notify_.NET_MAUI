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

        public DatabaseService()
        {
            Init();
        }

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

        public async Task AddNoteAsync(Note NewNote)
        {
            await Database.InsertAsync(new Note { ID=1, DateOfCreation=DateTime.Now, Entry="Hi", Title="Sigma"});
        }
    }
}
