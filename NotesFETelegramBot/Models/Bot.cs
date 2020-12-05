using System.Collections.Generic;
using System.Threading.Tasks;

using Telegram.Bot;
using NotesFETelegramBot.Models.Commands;

namespace NotesFETelegramBot.Models
{
    public class Bot
    {
        private readonly TelegramBotClient client;
        private readonly Command[] commands;

        public IReadOnlyCollection<Command> Commands => commands;

        public Bot(Command[] commands) 
        {
            client = new TelegramBotClient(AppSettings.Key);
            this.commands = commands;
        }

        public async Task<TelegramBotClient> Get()
        {
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}