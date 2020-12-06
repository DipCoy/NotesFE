using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using NotesFETelegramBot.Models;

namespace NotesFETelegramBot.Controllers
{
    [ApiController]
    [Route(@"bot")]
    public class MessageController : ControllerBase
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