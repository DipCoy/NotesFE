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

        [Route("board/{link}")]
        public IActionResult ListBoard(string link)
        {
            if (boardService.TryGetBoard(link, out var board))
                return View(board);
            return NotFound();
        }
        

        [HttpGet]
        [Route("/new")]
        public IActionResult CreateBoard()
        {
            return View();
        }
        
        [HttpGet]
        [Route("/")]
        public IActionResult ShowMain()
        {
            return View();
        }
        
        [HttpPost]
        [Route("/new")]
        public IActionResult CreateBoard(string stickerText)
        {
            var stickerContent = new StickerContent(stickerText);
            var stickers = new List<Sticker> {new Sticker(stickerContent)};
            var boardContent = new BoardContent(stickers);
            var board = new Board(boardContent);
            if (boardService.TryAddBoard(board))
                return Redirect($"board/{board.Link}");// Выводим 1, вместо {id} чисто для теста
            return Conflict();
        }
    }
}