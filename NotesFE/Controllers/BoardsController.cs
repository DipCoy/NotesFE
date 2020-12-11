using System;
using System.Collections.Generic;
using Application;
using Application.Converters;
using Domain.Models;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace NotesFE.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardService boardService;
        private readonly IUserService userService;

        public BoardsController(IBoardService boardService, IUserService userService)
        {
            this.boardService = boardService;
            this.userService = userService;
        }

        [Route("board/{link}")]
        public IActionResult ListBoard(string link)
        {
            Console.WriteLine(User.Identity.Name);
            Console.WriteLine(User.Identity.IsAuthenticated);
            if (boardService.TryGetBoard(link, out var board))
            {
                if (board.IsPublic)
                {
                    return View(board);
                }
                
                if (!User.Identity.IsAuthenticated)
                {
                    return Redirect("/login");
                }
                if (userService.TryGetUser(User.Identity.Name, out var user))
                {
                    if (board.HasAccess(user))
                    {
                        return View(board);
                    }

                    return new ForbidResult();
                }
                return Redirect("/");
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
        public IActionResult CreateBoard(BoardModel boardModel)
        {
            var board = Convert(boardModel);
            
            if (boardService.TryAddBoard(board, out var link))
                return Redirect($"board/{link}");
            return Conflict();
        }

        private Board Convert(BoardModel model)
        {
            var stickers = new List<Sticker>();
            foreach (var text in model.StickersText)
            {
                var stickerContent = new StickerContent(text);
                var sticker = new Sticker(stickerContent);
                stickers.Add(sticker);
            }
            var boardContent = new BoardContent(stickers);

            List<Guid> accessed = null;
            if (model.AccessType == "Private")
            {
                accessed = new List<Guid>();

                foreach (var login in model.GetLoginsOfAccessedUsers())
                {
                    if (userService.TryGetUser(login, out var user))
                    {
                        accessed.Add(user.Id);
                    }
                }
            }

            return new Board(boardContent, accessed);
        }
    }
}