using System;
using System.Collections.Generic;
using Application.Converters;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace NotesFE.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardService boardService;

        public BoardsController(IBoardService boardService)
        {
            this.boardService = boardService;
        }

        [Route("board/{id}")]
        public IActionResult ListBoard(int id)
        {
            if (boardService.TryGetBoard(id, out var board))
                return View(board);
            return NotFound();
        }

        [HttpGet]
        [Route("newboard")]
        public IActionResult CreateBoard()
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
            if (boardService.TryAddBoard(board))
                return Redirect($"board/{id}");
            return Conflict();
        }

     
    }
}