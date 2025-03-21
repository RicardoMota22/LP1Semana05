using System;
using System.Security.Cryptography;
using Spectre.Console;



public static class Program
{
    static void Main(string [] args)
    {
 
        if(args.Equals(""))
        {
            CanvasImage image = new CanvasImage("tux.jpg");
            // Set the max width of the image.
            image.MaxWidth(24);
            // Render the image to the console
            AnsiConsole.Write(image);
        }
        if(args[0] = "OIP.jpg" + args[1])
        {
            CanvasImage image1 = new CanvasImage("OIP.jpg");
            // Set the max width of the image.
            int arg = Convert.ToInt32(args[1]);
            image1.MaxWidth(arg);
            // Render the image to the console
            AnsiConsole.Write(image1);

        }
    }

}