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
            Console.WriteLine(User.Identity.Name);
            Console.WriteLine(User.Identity.IsAuthenticated);
            if (boardService.TryGetBoard(link, out var board))
            {
                return View(board);   
            }
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
        public IActionResult CreateBoard(string[] stickersText)
        {
            var stickers = new List<Sticker>();
            foreach (var text in stickersText)
            {
                var stickerContent = new StickerContent(text);
                var sticker = new Sticker(stickerContent);
                stickers.Add(sticker);
            }
            var boardContent = new BoardContent(stickers);
            var board = new Board(boardContent);
            if (boardService.TryAddBoard(board, out var link))
                return Redirect($"board/{link}");
            return Conflict();
        }
    }
}