using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace azure_churchbot
{
    public class commands
    {
        public async Task Ping(CommandContext ctx)
        {
            await ctx.RespondAsync("Pong!");
        }
    }

}