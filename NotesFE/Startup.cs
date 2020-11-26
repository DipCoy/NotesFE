using Application;
using Application.Converters;
using Domain.Models;
using Infrastructure;
using Infrastructure.Records;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            
            services.AddSingleton<IBoardOperations, DefaultBoardOperations>();
            services.AddSingleton<IBoardService, DefaultBoardService>();
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
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}