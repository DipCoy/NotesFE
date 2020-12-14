using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class TimeTableConverter : IConverter<TimeTableRecord, TimeTable>
    {
        public TimeTable Convert(TimeTableRecord source)
        {
            return new TimeTable(source.Rows);
        }

        public TimeTableRecord Convert(TimeTable source)
        {
            return new TimeTableRecord()
            {
                Rows = source.Rows
            };
        }
    }
}