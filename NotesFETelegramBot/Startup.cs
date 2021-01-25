using Application;
using Application.Converters;
using Application.Converters.Access;
using Domain.Models;
using Domain.Models.Access;
using Infrastructure;
using Infrastructure.Records;
using Infrastructure.Records.Access;
using LiteDB;
using Microsoft.Extensions.DependencyInjection;

namespace NotesFETelegramBot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IBotService, BotService>();
            services.AddSingleton<IConverter<BoardRecord, Board>, BoardConverter>();
            services.AddSingleton<IConverter<BoardContentRecord, BoardContent>, BoardContentConverter>();
            services.AddSingleton<IConverter<StickerRecord, Sticker>, StickerConverter>();
            services.AddSingleton<IConverter<StickerContentRecord, StickerContent>, StickerContentConverter>();

            services.AddSingleton<IConverter<UserRecord, User>, UserConverter>();

            services.AddSingleton<IConverter<PrivateAccessRecord, PrivateAccessParameters>, PrivateAccessConverter>();

            services.AddSingleton(typeof(ILiteDatabase), new LiteDatabase("Boards.db"));

            services.AddSingleton<ILinkGenerator, MD5LinkGenerator>();
            services.AddSingleton<IDataBaseOperations, LiteDBDataBaseOperations>();
            
            services.AddSingleton<IBoardService, DefaultBoardService>();
            services.AddSingleton<IUserService, DefaultUserService>();

            services.AddSingleton(typeof(AllPossibleAccessServices));
        }
    }
}