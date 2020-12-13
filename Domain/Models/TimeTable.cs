using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class TimeTable
    {
        public IEnumerable<Tuple<string, string>> Rows { get; private set; }

        public TimeTable(IEnumerable<Tuple<string, string>> rows)
        {
            Rows = rows;
        }
    }
}