using POE_Part_1.Properties;
using System.Media;

internal class Program
{
    private static void Main(string[] args)
    {
        // Plays welcome sound and displays ASCII art banner
        SoundPlayer player = new SoundPlayer(Resources.welcome);
        player.Play();
        Console.Write("                                                                             \r\n                                                                             \r\n▄█████ ▄▄ ▄▄ ▄▄▄▄  ▄▄▄▄▄ ▄▄▄▄   ▄▄▄▄ ▄▄▄▄▄  ▄▄▄▄ ▄▄ ▄▄ ▄▄▄▄  ▄▄ ▄▄▄▄▄▄ ▄▄ ▄▄ \r\n██     ▀███▀ ██▄██ ██▄▄  ██▄█▄ ███▄▄ ██▄▄  ██▀▀▀ ██ ██ ██▄█▄ ██   ██   ▀███▀ \r\n▀█████   █   ██▄█▀ ██▄▄▄ ██ ██ ▄▄██▀ ██▄▄▄ ▀████ ▀███▀ ██ ██ ██   ██     █   \r\n                                                                             ");
        Console.WriteLine("                                                                               \r\n                                                                               \r\n▄████▄ ▄▄   ▄▄  ▄▄▄  ▄▄▄▄  ▄▄▄▄▄ ▄▄  ▄▄ ▄▄▄▄▄  ▄▄▄▄  ▄▄▄▄   █████▄  ▄▄▄ ▄▄▄▄▄▄ \r\n██▄▄██ ██ ▄ ██ ██▀██ ██▄█▄ ██▄▄  ███▄██ ██▄▄  ███▄▄ ███▄▄   ██▄▄██ ██▀██  ██   \r\n██  ██  ▀█▀█▀  ██▀██ ██ ██ ██▄▄▄ ██ ▀██ ██▄▄▄ ▄▄██▀ ▄▄██▀   ██▄▄█▀ ▀███▀  ██   \r\n                                                                               ");
        
        // Collects username for personalization
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Visual.TypeTextLine("Hello, " + userName + ", and welcome to the Cybersecurity Awareness Bot. Feel free to ask any questions related to cybersecurity\n");

        // Main conversation loop
        bool continueConversation = true;
        while (continueConversation)
        {
            Visual.DisplayUserPrompt();
            string userInput = Console.ReadLine();

            // Skip empty input
            if (string.IsNullOrWhiteSpace(userInput))
            {
                continue;
            }

            // Gets bot response and displays it to the user
            string response = Bot.GetBotResponse(userInput.ToLower());
            Visual.DisplayBotResponse(response);

            // Checks for exit keywords to end conversation
            if (userInput.ToLower().Contains("bye") || userInput.ToLower().Contains("goodbye") || userInput.ToLower().Contains("exit"))
            {
                continueConversation = false;
            }
        }
    }
}