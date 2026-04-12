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

    
	
	

	public static void WriteColored(string text, ConsoleColor color)
	{
		ConsoleColor originalColor = Console.ForegroundColor;
		Console.ForegroundColor = color;
		Console.Write(text);
		Console.ForegroundColor = originalColor;
	}

	public static void WriteColoredLine(string text, ConsoleColor color)
	{
		WriteColored(text + Environment.NewLine, color);
	}

	public static void DisplayBotResponse(string response, int delayMs = 20)
	{
		Console.Write("Bot: ");
		ConsoleColor originalColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Cyan;
		TypeText(response, delayMs);
		Console.ForegroundColor = originalColor;
		Console.WriteLine("\n");
	}

	public static void DisplayUserPrompt()
	{
		WriteColored("You: ", ConsoleColor.Green);
	}

	
}
