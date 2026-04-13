using System;

public class Chatbot
{
    private string userName;

    public void Start()
    {
        UIHelper.PrintLogo();
        AudioPlayer.PlayGreeting();

        UIHelper.TypeText("Welcome to the Cybersecurity Awareness Bot!", ConsoleColor.Green);
        UIHelper.PrintDivider();

        // Part 3: Ask for name
        UIHelper.TypeText("To get started, what is your name?", ConsoleColor.White);
        Console.Write("> ");
        userName = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(userName))
        {
            userName = "Guest";
        }

        UIHelper.TypeText($"\nHello, {userName}! Let's talk about staying safe online.", ConsoleColor.Cyan);

        RunChatLoop();
    }

    private void RunChatLoop()
    {
        bool isRunning = true;
        while (isRunning)
        {
            UIHelper.PrintDivider();
            UIHelper.TypeText("What would you like to ask me? (Type 'exit' to quit)", ConsoleColor.Yellow);
            Console.Write($"[{userName}] > ");
            string input = Console.ReadLine()?.Trim().ToLower();

            // Part 5: Input Validation for empty entries
            if (string.IsNullOrEmpty(input))
            {
                UIHelper.TypeText("I didn't catch that. Please type a question or command.", ConsoleColor.Red);
                continue;
            }

            // Part 4 & 5: Basic Response System and default fallback
            switch (input)
            {
                case "exit":
                case "quit":
                    UIHelper.TypeText($"Stay safe out there, {userName}. Goodbye!", ConsoleColor.Green);
                    isRunning = false;
                    break;
                case "how are you?":
                case "how are you":
                    UIHelper.TypeText("I am functioning perfectly and ready to help you secure your data!", ConsoleColor.Cyan);
                    break;
                case "what's your purpose?":
                case "what is your purpose":
                    UIHelper.TypeText("My purpose is to educate you on cybersecurity best practices.", ConsoleColor.Cyan);
                    break;
                case "what can i ask you about?":
                case "help":
                    UIHelper.TypeText("Try asking me about:\n- Password safety\n- Phishing\n- Safe browsing", ConsoleColor.Cyan);
                    break;
                case "password safety":
                case "passwords":
                    UIHelper.TypeText("Use complex, unique passwords for every account. Enable Two-Factor Authentication (2FA) wherever possible.", ConsoleColor.Cyan);
                    break;
                case "phishing":
                    UIHelper.TypeText("Phishing is when attackers impersonate trusted entities to steal data. Always verify sender email addresses and never click suspicious links.", ConsoleColor.Cyan);
                    break;
                case "safe browsing":
                    UIHelper.TypeText("Look for 'https://' in the URL, avoid public Wi-Fi for banking, and keep your browser updated.", ConsoleColor.Cyan);
                    break;
                default:
                    // Part 5: Graceful fallback for unsupported queries
                    UIHelper.TypeText("I didn't quite understand that. Could you rephrase? (Type 'help' to see what I know)", ConsoleColor.Red);
                    break;
            }
        }
    }
}