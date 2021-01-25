using System.Collections.Generic;
using System.Threading.Tasks;

using Telegram.Bot;
using NotesFETelegramBot.Commands;

namespace NotesFETelegramBot
{
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
            var me = await botClient.GetMeAsync();
            return botClient;
        }
    }
}