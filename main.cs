using Impostor.Api.Events.Managers;
using Impostor.Api;
using Impostor.Api.Plugins;
using Impostor.Api.Innersloth;
using Impostor.Plugins.ImpostorTeleBot.Telegram;

using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

using Microsoft.Extensions.Logging;

namespace Impostor.Plugins.ImpostorTeleBot
{
    [ImpostorPlugin(
        package:    "com.Kizaing.TeleBot",
        name:       "ImpostorTeleBot",
        author:     "Kizaing",
        version:    "1.0"
    )]
    public class ImpostorTeleBot : PluginBase
    {
        private readonly ILogger<ImpostorTeleBot> _logger;
        private Bot _bot;
        private readonly Config config;

        public ImpostorTeleBot(ILogger<ImpostorTeleBot> logger, IEventManager eventManager)
        {
            _logger = logger;

            string configFile = File.ReadAllText("./config.telegram.json");
            config = JsonSerializer.Deserialize<Config>(configFile);

            _bot = new Bot(config);
            
        }
    }
    public class Config 
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}