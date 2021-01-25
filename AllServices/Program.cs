using System;
using System.Threading;
using NotesFE;
using NotesFETelegramBot;

namespace AllServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new Thread(x => NotesFE.Program.Main(args));
            var tg = new Thread(x => NotesFETelegramBot.Program.Main());
            web.Start();
            tg.Start();
            web.Join();
            tg.Join();
        }
    }
}
