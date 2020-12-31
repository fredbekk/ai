using Ai.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ai.Data
{
    public class WordDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public WordDatabase(string dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<Word>().Wait();
        }

        public Task<List<Word>> GetAll(WordType? type = null)
        {
            if(type == null)
            {
                return _database.Table<Word>().ToListAsync();
            }

            return _database.Table<Word>().Where(w => w.Type == type).ToListAsync();
        }

        public Task<Word> Get(int id)
        {
            return _database.Table<Word>().Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveSubject(Word subject)
        {
            subject.Type = WordType.Subject;
            if(subject.Id != 0)
            {
                return _database.UpdateAsync(subject);
            }

            return _database.InsertAsync(subject);
        }

        public Task<int> SaveVerb(Word verb)
        {
            verb.Type = WordType.Verb;
            if (verb.Id != 0)
            {
                return _database.UpdateAsync(verb);
            }

            return _database.InsertAsync(verb);
        }

        public Task<int> SavePlace(Word place)
        {
            place.Type = WordType.Place;
            if (place.Id != 0)
            {
                return _database.UpdateAsync(place);
            }

            return _database.InsertAsync(place);
        }

        public Task<int> Delete(Word subject)
        {
            return _database.DeleteAsync(subject);
        }
    }
}
