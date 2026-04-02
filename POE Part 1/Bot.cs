using System;

internal class Bot
{
    public static string GetBotResponse(string userInput)
    {
        if (ContainsKeywords(userInput, new[] { "how are you", "how's it going", "what's up", "wazzam", "hud", }))
        {
            return "I'm doing great, thank you for asking! I'm here to help you learn about cybersecurity best practices. What would you like to know?";
        }

        if (ContainsKeywords(userInput, new[] { "purpose", "what can i ask", "what can you help", "help" }))
        {
            return "I'm here to help you understand important cybersecurity topics including:\n" +
                   "• Password Safety - how to create and protect strong passwords\n" +
                   "• Phishing - how to recognize and avoid phishing attacks\n" +
                   "• Safe Browsing - practices to stay secure online\n" +
                   "Feel free to ask me about any of these topics!";
        }

        if (ContainsKeywords(userInput, new[] { "password", "strong password", "password safety" }))
        {
            return "Password Safety Tips:\n" +
                   "• Use at least 12 characters with a mix of uppercase, lowercase, numbers, and symbols\n" +
                   "• Avoid using personal information (birthdays, names, addresses)\n" +
                   "• Never reuse passwords across multiple accounts\n" +
                   "• Use a password manager to securely store your passwords\n" +
                   "• Change passwords immediately if you suspect a breach\n" +
                   "• Enable two-factor authentication (2FA) for extra security";
        }

        if (ContainsKeywords(userInput, new[] { "phishing", "phishing email", "suspicious email", "fishy" }))
        {
            return "Phishing Prevention:\n" +
                   "• Be suspicious of emails asking for personal or financial information\n" +
                   "• Check sender email addresses carefully - they may look similar to legitimate ones\n" +
                   "• Hover over links before clicking to see the actual URL\n" +
                   "• Look for spelling errors and poor grammar in emails\n" +
                   "• Legitimate companies never ask for passwords via email\n" +
                   "• When in doubt, contact the company directly using a verified phone number or website\n" +
                   "• Report phishing emails to your IT department";
        }

        if (ContainsKeywords(userInput, new[] { "browsing", "safe browsing", "online safety", "web safety" }))
        {
            return "Safe Browsing Practices:\n" +
                   "• Always ensure websites use HTTPS (look for the padlock icon)\n" +
                   "• Keep your browser and operating system updated with the latest security patches\n" +
                   "• Use antivirus and anti-malware software\n" +
                   "• Avoid downloading files from untrusted sources\n" +
                   "• Be cautious of pop-ups and suspicious advertisements\n" +
                   "• Use a VPN when connecting to public Wi-Fi networks\n" +
                   "• Clear your browser cache and cookies regularly";
        }

        return "I'm not sure about that topic. I can help you with questions about password safety, phishing prevention, and safe browsing practices. What would you like to know?";
    }
    private static bool ContainsKeywords(string input, string[] keywords)
    {
        return keywords.Any(keyword => input.Contains(keyword));
    }
}
