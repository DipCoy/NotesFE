using System;
using System.Collections.Generic;

namespace Infrastructure.Records
{
    public class TimeTableRecord
    {
        public IEnumerable<Tuple<string, string>> Rows { get; set; }
    }
}