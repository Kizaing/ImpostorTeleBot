using Telegram.Bot;

namespace Impostor.Plugins.ImpostorTeleBot.Telegram
{
    

    public class Bot
    {
        public static Config config;

        public Bot(Config _config) {

            config = _config;
            TelegramBotClient botClient = new TelegramBotClient(config.Token);
        }
    }
}