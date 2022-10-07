using static System.Console;
using System;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file
// string us = dec.ToString("C", new CultureInfo("en-US"));
Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
// Console.Write("Type your first name and press ENTER: ");
// string firstName = Console.ReadLine();
// Console.Write("Type your age and press ENTER: ");
// string age = Console.ReadLine();
// Console.WriteLine(
//  $"Hello {firstName}, you look good for {age}.");
// WriteLine($"There are {args.Length} arguments.");
// foreach (String i in args)
// {
//        Console.WriteLine(i);
// }
if (args.Length < 4)
{
       WriteLine("You must specify two colors and dimensions, e.g.");

       WriteLine("dotnet run red yellow 80 40");
       return; // stop running
}
ForegroundColor = (ConsoleColor)Enum.Parse(
 enumType: typeof(ConsoleColor),
 value: args[0],
 ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
 enumType: typeof(ConsoleColor),
 value: args[1],
 ignoreCase: true);
WindowWidth = int.Parse(args[2]);
WindowHeight = int.Parse(args[3]);


