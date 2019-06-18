using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace idkwtfisgoingon
{
	public class Program
	{
		private DiscordSocketClient _client;
		
		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();

			_client.Log += Log;
			_client.MessageReceived += MessageReceived;

			string token = "MzYwOTY3ODE2OTc3MDU1NzQ0.DMAAIA.SD4-lvZf21thEYtm-iOnTKB9wJY";
			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			// Block this task until the program is closed.
			await Task.Delay(-1);
		}

		private async Task MessageReceived(SocketMessage message)
		{
			if (message.Content.Contains("hate"))
			{
			await message.Channel.SendMessageAsync("Something Something let's play Checkers : ^)");
			}
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return  Task.CompletedTask;
		}
	}
}