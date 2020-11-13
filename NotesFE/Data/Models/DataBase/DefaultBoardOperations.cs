using System;
using System.Collections.Generic;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase
{
    public class DefaultBoardOperations : IBoardOperations
    {
        private Dictionary<int, Board> boards = new Dictionary<int, Board>();

        public DefaultBoardOperations()
        {
            var stickerContent = new StickerContent("ABC");
            var stickers = new List<Sticker> {new Sticker(stickerContent)};
            var boardContent = new BoardContent(stickers);
            var board = new Board(1, boardContent);
            boards.Add(1, board);
        }
        public bool TryGetBoard(int id, out Board board)
        {
            if (!boards.ContainsKey(id))
            {
                board = null;
                return false;
            }

            board = boards[id];
            return true;
        }

        public bool TryAddBoard(Board board)
        {
            if (boards.ContainsKey(board.Id))
                return false;
            boards.Add(board.Id, board);
            return true;
        }
    }
}