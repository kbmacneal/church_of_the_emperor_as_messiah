using System.Threading.Tasks;
using Discord;
using System;

namespace emperor3.Classes
{
    public class churchbot
    {
        public static void Main(string[] args) => new churchbot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        
        }


}