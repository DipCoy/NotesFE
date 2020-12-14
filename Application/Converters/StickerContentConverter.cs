using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class StickerContentConverter: IConverter<StickerContentRecord, StickerContent>
    {
        private readonly IConverter<TimeTableRecord, TimeTable> timeTableConverter;

        public StickerContentConverter(IConverter<TimeTableRecord, TimeTable> timeTableConverter)
        {
            this.timeTableConverter = timeTableConverter;
        }

        public StickerContent Convert(StickerContentRecord source)
        {
            return new StickerContent(source.Text, timeTableConverter.Convert(source.TimeTable));
        }

        public StickerContentRecord Convert(StickerContent source)
        {
            return new StickerContentRecord()
            {
                Text = source.Text,
                TimeTable = timeTableConverter.Convert(source.TimeTable)
            };
        }
    }
}