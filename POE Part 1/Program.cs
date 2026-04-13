using POE_Part_1.Properties;
using System.Media;

internal class Program
{
    private static void Main(string[] args)
    {
        SoundPlayer player = new SoundPlayer(Resources.welcome);
        player.Play();
        Console.Write("                                                                             \r\n                                                                             \r\n▄█████ ▄▄ ▄▄ ▄▄▄▄  ▄▄▄▄▄ ▄▄▄▄   ▄▄▄▄ ▄▄▄▄▄  ▄▄▄▄ ▄▄ ▄▄ ▄▄▄▄  ▄▄ ▄▄▄▄▄▄ ▄▄ ▄▄ \r\n██     ▀███▀ ██▄██ ██▄▄  ██▄█▄ ███▄▄ ██▄▄  ██▀▀▀ ██ ██ ██▄█▄ ██   ██   ▀███▀ \r\n▀█████   █   ██▄█▀ ██▄▄▄ ██ ██ ▄▄██▀ ██▄▄▄ ▀████ ▀███▀ ██ ██ ██   ██     █   \r\n                                                                             ");
        Console.WriteLine("                                                                               \r\n                                                                               \r\n▄████▄ ▄▄   ▄▄  ▄▄▄  ▄▄▄▄  ▄▄▄▄▄ ▄▄  ▄▄ ▄▄▄▄▄  ▄▄▄▄  ▄▄▄▄   █████▄  ▄▄▄ ▄▄▄▄▄▄ \r\n██▄▄██ ██ ▄ ██ ██▀██ ██▄█▄ ██▄▄  ███▄██ ██▄▄  ███▄▄ ███▄▄   ██▄▄██ ██▀██  ██   \r\n██  ██  ▀█▀█▀  ██▀██ ██ ██ ██▄▄▄ ██ ▀██ ██▄▄▄ ▄▄██▀ ▄▄██▀   ██▄▄█▀ ▀███▀  ██   \r\n                                                                               ");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Visual.TypeTextLine("Hello, " + userName + ", and welcome to the Cybersecurity Awareness Bot. Feel free to ask any questions related to cybersecurity\n");

        
        bool continueConversation = true;
        while (continueConversation)
        {
            Visual.DisplayUserPrompt();
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                continue;
            }

            string response = Bot.GetBotResponse(userInput.ToLower());
            Visual.DisplayBotResponse(response);

            if (userInput.ToLower().Contains("bye") || userInput.ToLower().Contains("goodbye") || userInput.ToLower().Contains("exit"))
            {
                continueConversation = false;
            }
        }
    }
}