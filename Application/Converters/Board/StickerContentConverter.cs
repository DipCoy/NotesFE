using Domain.Models.Board;
using Infrastructure.Records.Board;

namespace Application.Converters.Board
{
    public class StickerContentConverter: IConverter<StickerContentRecord, StickerContent>
    {
        public StickerContent Convert(StickerContentRecord source)
        {
            return new StickerContent(source.Text, source.TimeTable);
        }

        public StickerContentRecord Convert(StickerContent source)
        {
            return new StickerContentRecord()
            {
                Text = source.Text,
                TimeTable = source.TimeTable
            };
        }
    }
}