using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;


namespace azure_churchbot
{
    class startbot
    {
        static DiscordClient discord;
        static CommandsNextModule commands;
        public static string botToken;

        public void Main()
        {
            MainAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = botToken,
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("ping"))
                    await e.Message.RespondAsync("pong!");
            };

            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = "cb!"
            });

            commands.RegisterCommands<commands>();

            await discord.ConnectAsync();
            await discord.GetConnectionsAsync();
            
            await Task.Delay(-1);
        }
    }
}