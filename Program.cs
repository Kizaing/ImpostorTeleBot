using System;
using Telegram.Bot;
using Impostor.Api;

namespace ImpostorBot
{
    class Program
    {
        static void Main(string[] args)
        { 
            var botClient = new TelegramBotClient("TOKEN HERE");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
        }
    }
}
