using Microsoft.AspNetCore.Mvc;Данил Савин,
using OkResult = Microsoft.AspNetCore.Mvc.OkResult;

[05.12.20 22:37]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using NotesFETelegramBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace NotesFETelegramBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message  = update.Message;
            var client   = await Bot.Get();

            foreach(var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }
            
            return Ok();
        }

    }
}