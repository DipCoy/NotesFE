using System;
using System.Collections.Generic;
using Application;
using Application.Converters;
using Application.Services.User;
using Domain.Models;
using Domain.Models.Access;
using Domain.Models.Board;
using NotesFE.Views.ViewModels.Board;

namespace NotesFE.Converters
{
    public class BoardModelConverter : IConverter<BoardModel, Board>
    {
        private readonly IUserService userService;

        public BoardModelConverter(IUserService userService)
        {
            this.userService = userService;
        }

        public Board Convert(BoardModel boardModel)
        {
            var stickers = new List<Sticker>();
            boardModel.Content ??= new BoardContentModel();
            boardModel.Content.Stickers ??= new List<StickerModel>();
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

        public BoardModel Convert(Board source)
        {
            throw new System.NotImplementedException();
        }
    }
}