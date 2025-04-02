public class DisplayASCIIArt
{
    // B. Display ASCII Art (Cybersecurity Logo)
    public static void ShowASCIIArt()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;

        // ASCII Art 
        string asciiArt = @"
        ██████╗  ██████╗ ██████╗ ███████╗██████╗ ███████╗██╗   ██╗
        ██╔══██╗██╔═══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝
        ██████╔╝██║   ██║██████╔╝█████╗  ██████╔╝███████╗ ╚████╔╝ 
        ██╔═══╝ ██║   ██║██╔══██╗██╔══╝  ██╔═══╝ ╚════██║  ╚██╔╝  
        ██║     ╚██████╔╝██║  ██║███████╗██║     ███████║   ██║   
        ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝   ╚═╝   
                           G O D F R E Y
        ";

        //with a delay effect
        foreach (char c in asciiArt)
        {
            Console.Write(c);
            Thread.Sleep(1); // Smooth effect while displaying
        }

        Console.ResetColor();

    }
}
