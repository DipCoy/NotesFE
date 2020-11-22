using System.Collections.Generic;

namespace Infrastructure.Records
{
    public class BoardRecord
    {
        public int Id;
        public IDictionary<string, string> Attributes;
        public BoardContentRecord Content;
    }
}