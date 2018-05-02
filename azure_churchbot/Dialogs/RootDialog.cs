using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Threading;

namespace azure_churchbot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            //// calculate something for us to return
            //int length = (activity.Text ?? string.Empty).Length;

            //// return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            if (activity.Text.ToString().Split('!')[0] == "start")
            {
                await StartBotASync(activity.Text.ToString().Split('!')[1]);
                context.PostAsync("Bot Started");
            }
            else if (activity.Text.ToString().Split('!')[0] == "stop")
            {
                context.PostAsync("Bot Started");
            }
            else
            {
                await context.PostAsync($"Invalid request.");
            }
            context.Wait(MessageReceivedAsync);
        }

        private Task StartBotASync(string start_code)
        {
            startbot bot = new startbot();
            startbot.botToken = start_code;
            Thread t = new Thread(bot.Main);
            t.Start();

            return Task.CompletedTask;
        }
    }
}