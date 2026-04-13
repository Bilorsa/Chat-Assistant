using System;
using System.Threading;

public static class UIHelper
{
    public static void PrintLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
   _____       ___.                 __________        __   
  /  _  \___.__\_ |__   ___________ \______   \ _____/  |_ 
 /  /_\  \   |  || __ \_/ __ \_  __ \ |    |  _//  _ \   __\
/    |    \___  || \_\ \  ___/|  | \/ |    |   (  <_> )  |  
\____|__  / ____||___  /\___  >__|    |______  /\____/|__|  
        \/\/         \/     \/               \/             
        ");
        Console.ResetColor();
        PrintDivider();
    }

    public static void PrintDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(new string('=', 60));
        Console.ResetColor();
    }

    // Creates the conversational typing effect
    public static void TypeText(string text, ConsoleColor color = ConsoleColor.White, int delayMs = 25)
    {
        Console.ForegroundColor = color;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMs);
        }
        Console.WriteLine();
        Console.ResetColor();
    }

    public static void PrintColoredText(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}