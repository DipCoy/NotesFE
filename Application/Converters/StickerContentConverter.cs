using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class StickerContentConverter: IConverter<StickerContentRecord, StickerContent>
    {
        public StickerContent Convert(StickerContentRecord source)
        {
            return new StickerContent(source.Text);
        }

        public StickerContentRecord Convert(StickerContent source)
        {
            return new StickerContentRecord()
            {
                Text = source.Text
            };
        }
    }
}