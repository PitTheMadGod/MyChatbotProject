 using System.Media; 
 public class Greeting
{
    // Play the initial voice greeting
    public static void PlayVoiceGreeting()
    {
        string filePath = "Recording.wav";

        // Use switch expression to check file existence and play sound
        switch (File.Exists(filePath))
        {
            case true:
                PlaySound(filePath);
                break;
            case false:
                Console.WriteLine("Warning: 'Recording.wav' not found. Skipping voice greeting.");
                break;
        }
    }

    // Ask for the user's name (with validation)
    public string AskName()
    {
        Console.Write("\nWhat is your name? ");
        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Please enter a valid name: ");
            userName = Console.ReadLine();
        }

        return userName;
    }

    // Greet the user while playing Chatstart.wav
    public void SayHello(string userName)
    {
        string filePath = "Chatstart.wav";

        // Set time delay before greeting
        Console.Write("\nLoading...");
        Thread.Sleep(1000);
        Console.Clear();

        // Use switch expression 
        switch (File.Exists(filePath))
        {
            case true:
                PlaySound(filePath, false); // Asynchronous play
                break;
            case false:
                Console.WriteLine("Warning: 'Chatstart.wav' not found. Skipping greeting sound.");
                break;
        }

        // Display the greeting message
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello, {userName}! How can I help you today?");
        Console.ResetColor();
    }
  private static void PlaySound(string filePath, bool sync = true)
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                switch (sync)
                {
                    case true:
                        player.PlaySync(); // Synchronous play
                        break;
                    case false:
                        player.Play(); // Asynchronous play
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }
}
