using System.IO;
using System.Linq;
using Application;
using Application.Converters;
using Application.Converters.Access;
using Application.Converters.Board;
using Application.Converters.User;
using Application.Services.Access;
using Application.Services.Board;
using Application.Services.Link;
using Application.Services.User;
using Domain.Models;
using Domain.Models.Access;
using Domain.Models.Board;
using Domain.Models.User;
using Infrastructure;
using Infrastructure.DataBases;
using Infrastructure.Records;
using Infrastructure.Records.Access;
using Infrastructure.Records.Board;
using Infrastructure.Records.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using LiteDB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using NotesFE.Converters;
using NotesFE.Views.ViewModels.Board;

namespace NotesFE
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConverter<BoardRecord, Board>, BoardConverter>();
            services.AddSingleton<IConverter<BoardContentRecord, BoardContent>, BoardContentConverter>();
            services.AddSingleton<IConverter<StickerRecord, Sticker>, StickerConverter>();
            services.AddSingleton<IConverter<StickerContentRecord, StickerContent>, StickerContentConverter>();

            services.AddSingleton<IConverter<UserRecord, User>, UserConverter>();

            services.AddSingleton<IConverter<PrivateAccessRecord, PrivateAccessParameters>, PrivateAccessConverter>();

            services.AddSingleton<IConverter<BoardModel, Board>, BoardModelConverter>();

            services.AddSingleton(typeof(ILiteDatabase), new LiteDatabase("Boards.db"));

            services.AddSingleton<ILinkGenerator, MD5LinkGenerator>();
            services.AddSingleton<IDataBaseOperations, LiteDBDataBaseOperations>();
            
            services.AddSingleton<IBoardService, DefaultBoardService>();
            services.AddSingleton<IUserService, DefaultUserService>();

            services.AddSingleton(typeof(AllPossibleAccessServices));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/login");
                });
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "../../../../NotesFE/wwwroot")),
                RequestPath = ""
            });

            app.UseAuthentication();
            
            app.UseAuthorization();
            app.UseMvcWithDefaultRoute();
        }
    }
}