using System;
using System.Threading;

public class Visual
{
	public static void TypeText(string text, int delayMs = 30)
	{
		foreach (char c in text)
		{
			Console.Write(c);
			Thread.Sleep(delayMs);
		}
	}

    
	public static void TypeTextLine(string text, int delayMs = 30)
	{
		TypeText(text, delayMs);
		Console.WriteLine();
	}
	

    

	

	public static void WriteColored(string text, ConsoleColor color)
	{
		ConsoleColor originalColor = Console.ForegroundColor;
		Console.ForegroundColor = color;
		Console.Write(text);
		Console.ForegroundColor = originalColor;
	}

	

	public static void DisplayBotResponse(string response, int delayMs = 20)
	{
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("Bot: ");
		ConsoleColor originalColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Cyan;
		TypeText(response, delayMs);
		Console.ForegroundColor = originalColor;
		Console.WriteLine("\n");
	}

	public static void DisplayUserPrompt()
	{
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("You: ");
		ConsoleColor originalColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.DarkYellow;
    }

}
