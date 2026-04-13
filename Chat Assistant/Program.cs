using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cyber Aware Bot";
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}