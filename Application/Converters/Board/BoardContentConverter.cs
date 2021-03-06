using System.Linq;
using Domain.Models.Board;
using Infrastructure.Records.Board;

namespace Application.Converters.Board
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

        public BoardContentRecord Convert(BoardContent source)
        {
            return new BoardContentRecord()
            {
                Stickers = source.Stickers.Select(x => stickerConverter.Convert(x))
            };
        }
    }
}