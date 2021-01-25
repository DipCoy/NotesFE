using System;
using System.Collections.Generic;
using System.Linq;
using Application;
using Application.Converters;
using Application.Services.Board;
using Application.Services.User;
using Domain.Models;
using Domain.Models.Access;
using Domain.Models.Board;
using Microsoft.AspNetCore.Mvc;
using NotesFE.Views.ViewModels.Board;

namespace NotesFE.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardService boardService;
        private readonly IUserService userService;
        private readonly IConverter<BoardModel, Board> boardModelConverter;

        public BoardsController(IBoardService boardService, IUserService userService, IConverter<BoardModel, Board> boardModelConverter)
        {
            this.boardService = boardService;
            this.userService = userService;
            this.boardModelConverter = boardModelConverter;
        }

        [Route("board/{link}")]
        public IActionResult ListBoard(string link)
        {
            if (boardService.TryGetBoard(link, out var board))
            {
                // var res = string.Join("\n\n", board.Content.Stickers.Select(s => s.Content).Select(c =>
                // {
                //     var str = c.Text ?? "not text";
                //     str += "|| TimeTable: \n";
                //     var tb = c.TimeTable == null
                //         ? "not table"
                //         : string.Join("\n", c.TimeTable.Select(r => string.Join(":", r)));
                //     return str + tb;
                // }));
                
                //Console.WriteLine($"{board.AccessParameters.GetAccessType()}\n{res}\n|||");
                
                
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

                    return Redirect("/403");
                }
                return Redirect("/");
            }

            return Redirect("/404");
        }
        
        [HttpGet]
        [Route("edit/{link}")]
        public IActionResult EditBoard(string link)
        {
            if (boardService.TryGetBoard(link, out var board))
            {
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

                    return Redirect("/403");
                }
                return Redirect("/");
            }

            return Redirect("/404");
        }
        
        
        [HttpPost]
        [Route("edit/{link}")]
        public IActionResult EditBoard(BoardModel boardModel)
        {
            //TODO edit
            // var res = new List<string>();
            // foreach (var sm in boardModel.Content.Stickers)
            // {
            //     res.Add(sm.Content.Text);
            // }
            // return Content(string.Join("|||", res) +  RouteData.Values["link"]);
            
            boardModel.AccessedUsers += $" {User.Identity.Name}"; //TODO
            var board = boardModelConverter.Convert(boardModel);

            if (boardService.TryUpdateBoard(board, (string) RouteData.Values["link"]))
                return Redirect($"../board/{RouteData.Values["link"]}");
            return Conflict();
            
            // boardModel.AccessedUsers += $" {User.Identity.Name}";
            // boardModel.AccessType = "Public";
            // var board = boardModelConverter.Convert(boardModel);
            // boardService.TryUpdateBoard(board, (string) RouteData.Values["link"]);
            // return Redirect($"../board/{RouteData.Values["link"]}");
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
            return View(User);
        }

        [HttpPost]
        [Route("/new")]
        public IActionResult CreateBoard(BoardModel boardModel)
        {
            boardModel.AccessedUsers += $" {User.Identity.Name}"; //TODO
            var board = boardModelConverter.Convert(boardModel);

            if (boardService.TryAddBoard(board, out var link))
                return Redirect($"board/{link}");
            return Conflict();
        }
    }
}