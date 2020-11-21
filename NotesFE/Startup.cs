using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NotesFE.Data.Converter;
using NotesFE.Data.Models.DataBase;
using NotesFE.Data.Models.DataBase.Records;
using NotesFE.Data.Models.Domain;
using Pomelo.EntityFrameworkCore.MySql;

namespace NotesFE
{
    public class BoardDBService
    {
        public ILiteDatabase GetDatabase => new LiteDatabase("BoardsDB.db");
    }
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConverter<BoardContentRecord, BoardContent>, BoardContentConverter>();
            
            services.AddSingleton<IBoardOperations, DefaultBoardOperations>();
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