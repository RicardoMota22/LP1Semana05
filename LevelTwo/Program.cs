using Spectre.Console;


public static class Program
{
    private static void Main()
    {
 
        CanvasImage image = new CanvasImage("tux.jpg");
        // Set the max width of the image.
        image .MaxWidth(20);
        // Render the image to the console
        AnsiConsole . Write(image );
    }

}