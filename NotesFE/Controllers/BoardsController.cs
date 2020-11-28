using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NotesFE.Data.Models.Domain;
using NotesFE.Data.Models.DataBase;

namespace NotesFE.Controllers
{
    //Данный класс будет нам возращать html страницу, которая будет отображаться на самом сайте
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
            Board board;
            var result = dataBase.TryGetBoard(id, out board);
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