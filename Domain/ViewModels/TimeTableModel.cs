using System;
using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class TimeTableModel
    {
        public IEnumerable<Tuple<string, string>> Rows { get; set; }
    }
}