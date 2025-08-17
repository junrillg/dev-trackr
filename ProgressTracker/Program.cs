using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string progressFile = "progress_tracker.txt";
        
        if (args.Length == 0)
        {
            ShowHelp();
            return;
        }
        
        string command = args[0].ToLower();
        
        switch (command)
        {
            case "status":
                ShowStatus(progressFile);
                break;
            case "complete":
                if (args.Length >= 3)
                {
                    MarkComplete(progressFile, args[1], args[2]);
                }
                else
                {
                    Console.WriteLine("Usage: progress complete <week> <day>");
                }
                break;
            case "reset":
                ResetProgress(progressFile);
                break;
            default:
                ShowHelp();
                break;
        }
    }
    
    static void ShowHelp()
    {
        Console.WriteLine("DevTrackr Progress Tracker");
        Console.WriteLine("Usage:");
        Console.WriteLine("  progress status          - Show current progress");
        Console.WriteLine("  progress complete <week> <day> - Mark a day as complete");
        Console.WriteLine("  progress reset           - Reset all progress");
        Console.WriteLine("");
        Console.WriteLine("Examples:");
        Console.WriteLine("  progress complete 1 3    - Mark week 1, day 3 as complete");
    }
    
    static void ShowStatus(string progressFile)
    {
        if (!File.Exists(progressFile))
        {
            Console.WriteLine("No progress tracked yet. Use 'progress complete <week> <day>' to track progress.");
            return;
        }
        
        string[] lines = File.ReadAllLines(progressFile);
        Console.WriteLine("DevTrackr Progress:");
        Console.WriteLine("==================");
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    
    static void MarkComplete(string progressFile, string week, string day)
    {
        string entry = $"Week {week}, Day {day} - Completed on {DateTime.Now:yyyy-MM-dd}";
        
        // Check if already completed
        if (File.Exists(progressFile))
        {
            string[] lines = File.ReadAllLines(progressFile);
            foreach (string line in lines)
            {
                if (line.Contains($"Week {week}, Day {day}"))
                {
                    Console.WriteLine($"Week {week}, Day {day} already marked as complete.");
                    return;
                }
            }
        }
        
        File.AppendAllText(progressFile, entry + Environment.NewLine);
        Console.WriteLine($"Marked Week {week}, Day {day} as complete!");
    }
    
    static void ResetProgress(string progressFile)
    {
        if (File.Exists(progressFile))
        {
            File.Delete(progressFile);
            Console.WriteLine("Progress reset successfully.");
        }
        else
        {
            Console.WriteLine("No progress to reset.");
        }
    }
}