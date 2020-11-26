using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class StickerContentConverter: IConverter<StickerContentRecord, StickerContent>
    {
        public StickerContent Convert(StickerContentRecord source)
        {
            return null; //TODO
        }
    }
}