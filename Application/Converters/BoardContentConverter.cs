using System.Linq;
using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
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