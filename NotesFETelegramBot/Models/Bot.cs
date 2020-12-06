using System.Collections.Generic;
using System.Threading.Tasks;

using Telegram.Bot;
using NotesFETelegramBot.Models.Commands;

namespace NotesFETelegramBot.Models
{
    public class Bot1
    {
        private readonly TelegramBotClient client;
        private readonly Command[] commands;

        public IReadOnlyCollection<Command> Commands => commands;

        public Bot1(Command[] commands) 
        {
            client = new TelegramBotClient(AppSettings.Key);
            this.commands = commands;
        }

        public async Task<TelegramBotClient> GetClient()
        {
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
    
    public static class Bot
    {
        private static TelegramBotClient botClient;
        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());
            //TODO: Add more commands

            botClient = new TelegramBotClient(AppSettings.Key);
            string hook = string.Format(AppSettings.Url, "bot");
            await botClient.SetWebhookAsync(hook);
            return botClient;
        }
    }
}