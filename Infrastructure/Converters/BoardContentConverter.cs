using System.Linq;
using Domain;
using Infrastructure.Records;

namespace Infrastructure.Converter
{
    public class BoardContentConverter : IConverter<BoardContentRecord, BoardContent>
    {
        private readonly IConverter<StickerRecord, Sticker> stickerConverter;

        public BoardContentConverter(IConverter<StickerRecord, Sticker> stickerConverter)
        {
            this.stickerConverter = stickerConverter;
        }

        public BoardContent Convert(BoardContentRecord record)
        {
            return new BoardContent(record.Stickers.Select(x => stickerConverter.Convert(x)));
        }
    }
}