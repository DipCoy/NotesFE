using System.Collections.Generic;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace NotesFE.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardOperations dataBase;

        public BoardsController(IBoardOperations dataBase)
        {
            this.dataBase = dataBase;
        }
        
        [Route("board/{id}")]
        public ViewResult ListBoard(int id)
        {
            var result = dataBase.TryGetBoard(id, out var board);
            return View(board);
        }

        [HttpGet]
        [Route("newboard")]
        public ViewResult CreateBoard()
        {
            return View();
        }
        
        [HttpPost]
        [Route("newboard")]
        public IActionResult CreateBoard(int id, string stickerText)
        {
            var stickerContent = new StickerContent(stickerText);
            var stickers = new List<Sticker> {new Sticker(stickerContent)};
            var boardContent = new BoardContent(stickers);
            var board = new Board(id, boardContent);
            dataBase.TryAddBoard(board);
            return Redirect($"board/{id}");
        }
    }
}