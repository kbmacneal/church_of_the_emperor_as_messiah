using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace churchbot
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }
        public SortedDictionary<int,string> Options { get; set; }
    }
    public class Vote
    {
        public User user = new User();
        public int QuestionID { get; set; }
        public int Choice { get; set; }

    }

    public class User
    {
        public string UserName { get; set; }
        public int ID { get; set; }
    }

    public class Votes
    {
        public List<Vote> votes { get; set; }
    }

    public class VoteMessage : ModuleBase<SocketCommandContext>
    {
        public string Message { get; set; }
        public async Task SendVoteMessage()
        {
            await ReplyAsync(this.Message);
        }
    }

    internal class Program
    {
        private static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection().AddSingleton(_client).AddSingleton(_commands).BuildServiceProvider();

            //event subscriptions
            _client.Log += Log;

            //before publish, fill this out
            string botToken = "";

            await RegisterCommandAsync();

            await _client.LoginAsync(TokenType.Bot, botToken);

            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        public async Task RegisterCommandAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;

            if (message is null || message.Author.IsBot)
            {
                return;
            }

            int argPosition = 0;

            if (message.HasStringPrefix("cb!", ref argPosition) || message.HasMentionPrefix(_client.CurrentUser, ref argPosition))
            {
                var context = new SocketCommandContext(_client, message);

                string logmessage = String.Concat(message.Author, " sent command ", message.Content);

                await Log(new LogMessage(LogSeverity.Info, "VERBOSE", logmessage));

                string fullcommand = message.Content;

                if (fullcommand.ToString().Contains("votefor"))
                {
                    //cb!votefor1:1
                        User user = new User();
                        Vote vote = new Vote();
                        int test = 0;

                        user.UserName = message.Author.ToString().Split('#')[0];

                        if(Int32.TryParse(message.Author.ToString().Split('#')[1], out test))
                        {
                            user.ID = test;
                        }
                        else
                        {
                            user.ID = 0;
                        }

                        if (Int32.TryParse(fullcommand.ToString().Split("votefor")[1].Split(":")[0], out test))
                        {
                            vote.QuestionID = test;
                        }
                        else
                        {
                            vote.QuestionID = 0;
                        }

                    if (Int32.TryParse(fullcommand.ToString().Split("votefor")[1].Split(":")[1], out test))
                    {
                        vote.Choice = test;
                    }
                    else
                    {
                        vote.Choice = 0;
                    }

                    vote.user = user;

                        await CastVote(vote);
                    
                }
                else if(fullcommand.ToString().Contains("votetally"))
                {
                    //cb!votetally1
                    int test = 0;

                    if (Int32.TryParse(fullcommand.ToString().Split("votetally")[1], out test))
                    {
                        await ReturnTally(test);
                    }
                    else
                    {
                        VoteMessage vm = new VoteMessage();
                        vm.Message = "Invalid request";
                        await vm.SendVoteMessage();
                    }

                }
                else
                {
                    var result = await _commands.ExecuteAsync(context, argPosition, _services);

                    if (!result.IsSuccess)
                    {
                        Console.WriteLine(result.ErrorReason);
                    }
                }
            }
        }

        private async Task CastVote(Vote vote)
        {
            if(System.IO.File.Exists("~/votes/" + vote.QuestionID.ToString() + ".json"))
            {
                string filecontents = System.IO.File.ReadAllText("~/votes/" + vote.QuestionID.ToString() + ".json");

                Votes votes = JsonConvert.DeserializeObject<Votes>(filecontents);

                if(votes.votes.Where(s=>s.user.UserName == vote.user.UserName).Count() > 0)
                {
                    VoteMessage voteMessage = new VoteMessage();

                    voteMessage.Message = String.Concat(vote.user.UserName, " has already cast their vote, and cannot do so again..");
                    await voteMessage.SendVoteMessage();

                    return;
                }
                else
                {
                    votes.votes.Add(vote);

                    string serialized = JsonConvert.SerializeObject(votes);

                    System.IO.File.WriteAllText("~/votes/" + vote.QuestionID.ToString() + ".json", serialized);

                    VoteMessage voteMessage = new VoteMessage();
                    //voteMessage.Message = String.Concat("In the matter of ", question.QuestionTitle, " ", vote.user.UserName, " ", "voted for option ", vote.Choice, " ", question.Options.Where(s => s.Key == vote.Choice).Select(s => s.Value))

                    voteMessage.Message = String.Concat(vote.user.UserName, " has successfully cast their vote.");
                    await voteMessage.SendVoteMessage();

                    return;
                }

                
            }
            else
            {
                VoteMessage voteMessage = new VoteMessage();
                voteMessage.Message = String.Concat("Vote is invalid. Please consult an Admin.");
                await voteMessage.SendVoteMessage();
                return;
            }
        }

        private async Task ReturnTally(int votenum)
        {
            if (System.IO.File.Exists("~/votes/" + votenum.ToString() + ".json"))
            {
                Votes tally = JsonConvert.DeserializeObject<Votes>("~/votes/" + votenum.ToString() + ".json");

                List<int> Options = tally.votes.Select(s => s.Choice).Distinct().ToList();

                foreach(int opt in Options)
                {
                    VoteMessage msgr = new VoteMessage();
                    msgr.Message = String.Concat("Tally for option ", votenum, " is ", tally.votes.Where(s => s.Choice == opt).Count());
                    await msgr.SendVoteMessage();
                }
                return;
            }
        }
    }
}