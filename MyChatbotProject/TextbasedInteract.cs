public class TextBasedInteract
{
    private static int userPoints = 0; // Tracks user points

    public static void StartChat(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nHello, {userName}! How can I help you today?");
        Console.ResetColor();

        Console.WriteLine("\nYou can ask about:");
        Console.WriteLine("1. How are you?");
        Console.WriteLine("2. Password safety (+10 Points)");
        Console.WriteLine("3. Phishing awareness (+10 Points)");
        Console.WriteLine("4. Type 'exit' to end the chat\n");

        while (true)
        {
            Console.Write($"\n{userName}: ");
            string userInput = Console.ReadLine()?.Trim().ToLower();

            switch (userInput)
            {
                case "1":
                case string input when input.Contains("how are you"):
                    DisplayMessage("Chatbot: I'm just a bot, but I'm here to help!", ConsoleColor.Magenta);
                    break;

                case "2":
                case string input when input.Contains("password safety"):
                    userPoints += 10;
                    DisplayAdvice("Password Safety", new string[]
                    {
                        "Use a strong password with at least 12 characters.",
                        "Include a mix of uppercase, lowercase, numbers, and symbols.",
                        "Avoid using personal information like your name or birthday.",
                        "Use a unique password for each account.",
                        "Enable two-factor authentication (2FA) whenever possible.",
                        "Change your passwords regularly, at least every few months.",
                        "Do not share your password with anyone.",
                        "Use a reputable password manager to store your credentials securely.",
                        "Watch out for keyloggers and malicious software that can steal your password.",
                        "Always log out from shared or public computers after use."
                    }, ConsoleColor.Green);
                    break;

                case "3":
                case string input when input.Contains("phishing"):
                    userPoints += 10;
                    DisplayAdvice("Phishing Awareness", new string[]
                    {
                        "Do not click on suspicious links in emails or messages.",
                        "Verify the sender's email address before responding to any request.",
                        "Be cautious of emails with urgent requests for personal information.",
                        "Check for grammatical mistakes in emails—scammers often make errors.",
                        "Do not download attachments from unknown or untrusted sources.",
                        "Legitimate companies will never ask for sensitive information via email.",
                        "Hover over links before clicking to check if they redirect to a fake website.",
                        "Use up-to-date antivirus software to detect phishing attempts.",
                        "Enable spam filters on your email to block potential phishing emails.",
                        "If you suspect an email is a phishing attempt, report it to the appropriate authorities."
                    }, ConsoleColor.Green);
                    break;

                case "4":
                case string input when input.Contains("exit"):
                    DisplayMessage($"Chatbot: Goodbye! Come see us again", ConsoleColor.Red);
                    return;

                default:
                    DisplayMessage("Chatbot: I didn't quite understand that. Could you rephrase?", ConsoleColor.Yellow);
                    break;
            }
        }
    }

    private static void DisplayMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void DisplayAdvice(string topic, string[] adviceList, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"\nChatbot: Here are some tips on {topic}:\n");
        for (int i = 0; i < adviceList.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {adviceList[i]}");
        }
        Console.ResetColor();
    }
}
