using Domain.Models.Board;
using Infrastructure.Records.Board;

namespace Application.Converters.Board
{
    public class StickerConverter: IConverter<StickerRecord, Sticker>
    {
        private readonly IConverter<StickerContentRecord, StickerContent> stickerContentConverter;

        public StickerConverter(IConverter<StickerContentRecord, StickerContent> stickerContentConverter)
        {
            this.stickerContentConverter = stickerContentConverter;
        }

        public Sticker Convert(StickerRecord record)
        {
            return new Sticker(stickerContentConverter.Convert(record.Content));
        }

        public StickerRecord Convert(Sticker source)
        {
            return new StickerRecord()
            {
                Content = stickerContentConverter.Convert(source.Content)
            };
        }
    }
}