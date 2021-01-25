using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain.Models;
using NotesFETelegramBot.Commands;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace NotesFETelegramBot
{
    public class BotService : IBotService
    {
        private TelegramBotClient botClient;
        private List<Command> commandsList;
        private IBoardService boardService;

        public IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public BotService(IBoardService boardService)
        {
            this.boardService = boardService;
            
            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());
            //TODO: Add more commands

            botClient = new TelegramBotClient(AppSettings.Key);
            botClient.OnMessage += OnMessage;
        }

        private async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            if (message is null || message.Type != MessageType.Text)
                return;

            Board board;
            var answer = "Not Found";
            if (boardService.TryGetBoard(message.Text, out board))
            {
                try
                {
                    foreach (var sticker in board.Content.Stickers)
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, sticker.Content.Text);
                    }
                }
                catch
                {
                    answer = "Error";
                    await botClient.SendTextMessageAsync(message.Chat.Id, answer);
                }
            }
            else
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, answer);
            }
        }

        public async Task Run()
        {
           var self = await botClient.GetMeAsync();
           botClient.StartReceiving(Array.Empty<UpdateType>());
        }

        public void Stop()
        {
            botClient.StopReceiving();
        }
    }
}