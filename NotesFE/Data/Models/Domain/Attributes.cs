using System.Collections.Generic;

namespace NotesFE.Data.Models.Domain
{
    public abstract class Attributes
    {
        public string Name { get; private set; }
        private IDictionary<string, string> dict;

        public string this[string name]
        {
            get => dict[name];
            set => dict[name] = value;
        }
    }
}