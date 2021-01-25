using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace NotesFETelegramBot
{
    public class Program
    {
        public static async Task Main()
        {
            var startup = new Startup();
            var serviceCollection = new ServiceCollection();
            startup.ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var botService = serviceProvider.GetService<IBotService>();
            await botService.Run();

            Console.ReadLine();
            botService.Stop();
        }
    }
}