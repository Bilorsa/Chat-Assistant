

using System;
using System.Diagnostics;
using System.IO;
using System.Media; // Ensure this using is present

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            // Locates the file in the execution directory
            string filePath = @"C:\Users\Student\source\repos\Chat Assistant\Chat Assistant\bin\Debug\net8.0\greeting.wav.wav";

            if (File.Exists(@"C:\Users\Student\source\repos\Chat Assistant\Chat Assistant\bin\Debug\net8.0\greeting.wav.wav"))
            {
                var player = new SoundPlayer(@"C:\Users\Student\source\repos\Chat Assistant\Chat Assistant\bin\Debug\net8.0\greeting.wav.wav");
                player.Play(); // Plays asynchronously so the app doesn't freeze
            }
            else
            {
                UIHelper.PrintColoredText("[System] Audio file 'greeting.wav' not found. Skipping...", ConsoleColor.Yellow);
            }
        }
        catch (Exception ex)
        {
            UIHelper.PrintColoredText($"[Error] Could not play audio: {ex.Message}", ConsoleColor.Red);
        }
    }
}




