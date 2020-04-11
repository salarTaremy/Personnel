using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelegramBotSharp;
using TelegramBot;
using TelegramBotSharp.Types;
using System.Data.SqlClient;
using System.Data;


namespace TelegramBot
{
     public class ClsBot
    {
        public ClsBot()
        {
            Console.WriteLine("Initializing Bot...");
            TelegramBotSharp.TelegramBot bot = new TelegramBotSharp.TelegramBot("318440383:AAE7qkx5oewer2JGz2sjtLe2oUBpLp40Wt0");
            Console.WriteLine("Bot initialized.");
            Console.WriteLine("Hi, i'm {0}! ID: {1}", bot.Me.FirstName, bot.Me.Id);
            new Task(PollMessages(bot)).Start();

            Console.ReadLine();
        }

        static async void PollMessages(TelegramBotSharp.TelegramBot bot_)
        {
            while (true)
            {
                var result = await bot_.GetMessages();
                foreach (Message m in result)
                {
                    if (m.Chat != null)
                    {
                        Console.WriteLine("[{0}] {1}: {2}", m.Chat.Title, m.From.Username, m.Text);
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", m.From.Username, m.Text);
                    }

                    HandleMessage(m);
                }
            }
        }



    }
}
