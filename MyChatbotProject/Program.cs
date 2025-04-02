class Program
{
    static void Main()
    {
        try
        {
            // Display ASCII Art
            DisplayASCIIArt.ShowASCIIArt();

            // Play the voice greeting from the Greeting class
            Greeting.PlayVoiceGreeting();

            Greeting greeting = new Greeting();
            string userName = greeting.AskName();

            // Greet the user (Chatstart.wav plays while greeting is displayed)
            greeting.SayHello(userName);

            // Start chatbot interaction with user
            TextBasedInteract.StartChat(userName);

             
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
 
