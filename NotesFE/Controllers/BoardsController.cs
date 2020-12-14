using System;
using System.Collections.Generic;
using System.Linq;
using Application;
using Application.Converters;
using Domain.Models;
using Domain.Models.Access;
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
                var res = string.Join("\n\n", board.Content.Stickers.Select(s => s.Content).Select(c =>
                {
                    var str = c.Text ?? "not text";
                    str += "|| TimeTable: \n";
                    var tb = c.TimeTable == null
                        ? "not table"
                        : string.Join("\n", c.TimeTable.Select(r => string.Join(":", r)));
                    return str + tb;
                }));
                
                Console.WriteLine($"{board.AccessParameters.GetAccessType()}\n{res}\n|||");
                
                
                
                
                if (board.AccessParameters.GetAccessType() == AccessType.Public)
                {
                    return View(board);
                }
                
                if (!User.Identity.IsAuthenticated)
                {
                    return Redirect("/login");
                }
                if (userService.TryGetUser(User.Identity.Name, out var user))
                {
                    if (board.AccessParameters.HasAccess(user))
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
            // var res = string.Join("\n\n", boardModel.Content.Stickers.Select(s => s.Content).Select(c =>
            // {
            //     var str = c.Text ?? "not text";
            //     str += "|| TimeTable: \n";
            //     var tb = c.TimeTable == null
            //         ? "not table"
            //         : string.Join("\n", c.TimeTable.Select(r => string.Join(":", r)));
            //     return str + tb;
            // }));
            // return Content($"{boardModel.AccessType}\n{res}\n||| users:{string.Join(",",boardModel.GetLoginsOfAccessedUsers())}");
            
            var board = Convert(boardModel);
            
            if (boardService.TryAddBoard(board, out var link))
                return Redirect($"board/{link}");
            return Conflict();
        }

        private Board Convert(BoardModel boardModel)
        {
            var stickers = new List<Sticker>();
            foreach (var stickerModel in boardModel.Content.Stickers)
            {
                var stickerContent = new StickerContent(stickerModel.Content.Text, stickerModel.Content.TimeTable);
                var sticker = new Sticker(stickerContent);
                stickers.Add(sticker);
            }
            var boardContent = new BoardContent(stickers);

            IAccessParameters accessParameters;
            switch (boardModel.AccessType)
            {
                case "Public":
                    accessParameters = new PublicAccessParameters();
                    break;
                case "Private":
                    var accessed = new List<Guid>();

                    foreach (var login in boardModel.GetLoginsOfAccessedUsers())
                    {
                        if (userService.TryGetUser(login, out var user))
                        {
                            accessed.Add(user.Id);
                        }
                    }
                    accessParameters = new PrivateAccessParameters(accessed);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return new Board(boardContent, accessParameters);

        }
    }
}