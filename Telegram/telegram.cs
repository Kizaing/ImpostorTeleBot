using Telegram.Bot;
using Telegram.Bot.Args;

namespace Impostor.Plugins.ImpostorTeleBot.Telegram
{
    public class Bot
    {
        static ITelegramBotClient botClient;

        public static Config config;

        public Bot(Config _config) {

            config = _config;
            botClient = new TelegramBotClient(config.Token);

            var me = botClient.GetMeAsync().Result;

            botClient.OnMessage += Bot_OnMessage;
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e) {
            if(e.Message.Text != null) {
                await botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text:   "You said:\n" + e.Message.Text
                );
            }
        }
    }
}