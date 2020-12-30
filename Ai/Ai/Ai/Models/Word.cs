using SQLite;
using System;

namespace Ai.Models
{
    public class Word
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public WordType Type { get; set; }
    }
}
