using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using NotesFETelegramBot;

namespace NotesFETelegramBot.Controllers
{
    [Route(@"bot")]
    public class MessageController : Controller
    {
        //public MessageController(Bot bot)
        //{
        //    this.bot = bot;
        //}
        [HttpPost]
        public async Task<OkResult> Post([FromBody]Update update)
        {
            //Console.WriteLine("!");
            var commands = Bot.Commands;
            var message  = update.Message;
            var client   = await Bot.GetBotClientAsync();
            await client.SendTextMessageAsync(message.Chat.Id, "Hello I'm ASP.NET Core Bot");

            return Ok();
            foreach(var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    await command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }

    }
}