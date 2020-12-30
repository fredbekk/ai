using Ai.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ai.Engine
{
    public class Generator
    {
        public (string, string, string) Generate(List<Word> subjects, List<Word> verbs, List<Word> places)
        {
            var subjectsLength = subjects.Count();
            var verbsLength = verbs.Count();
            var placesLength = places.Count();

            Random r = new Random();
            var subjectIndex = r.Next(0, subjectsLength - 1);
            var verbIndex = r.Next(0, verbsLength - 1);
            var placesIndex = r.Next(0, placesLength - 1);

            return (subjects[subjectIndex].Name, verbs[verbIndex].Name, places[placesIndex].Name);
        }
    }
}
