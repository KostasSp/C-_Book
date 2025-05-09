﻿using static System.Convert;

namespace CastingConverting;

class CastingConverting
{
       private static void Main(string[] args)
       {
              int a = 10;
              double b = a; // an int can be safely cast into a double
              Console.WriteLine(b);

              double c = 9.8;
              // int d = c; // compiler gives an error for this line
              // Console.WriteLine(d);

              int d = (int)c;
              Console.WriteLine(d); // d is 9 losing the .8 part
              long e = 5_000_000_000;
              int f = (int)e;
              Console.WriteLine($"e is {e:N0} and f is {f:N0}");
              e = long.MaxValue;
              f = (int)e;
              Console.WriteLine($"e is {e:N0} and f is {f:N0}");
              double g = 9.8;
              int h = ToInt32(g);
              Console.WriteLine($"g is {g} and h is {h}");
              int number = 12;
              Console.WriteLine(number.ToString());
              bool boolean = true;
              Console.WriteLine(boolean.ToString());
              DateTime now = DateTime.Now;
              Console.WriteLine(now.ToString());
              object me = new object();
              Console.WriteLine(me.ToString());
              byte[] binaryObject = new byte[128];
              // populate array with random bytes 
              (new Random()).NextBytes(binaryObject);
              Console.WriteLine("Binary Object as bytes:");
              for (int index = 0; index < binaryObject.Length; index++)
              {
                     Console.Write($"{binaryObject[index]:X} ");
              }
              Console.WriteLine();
              int age = int.Parse("27");
              DateTime birthday = DateTime.Parse("4 July 1900");
              Console.WriteLine($"I was born {age} years ago.");
              Console.WriteLine($"My birthday is {birthday}.");
              Console.WriteLine($"My birthday is {birthday:D}.");
              // int count = int.Parse("abc");
              Console.Write("How many eggs are there? ");
              int count;
              string input = Console.ReadLine();
              if (int.TryParse(input, out count))
              {
                     Console.WriteLine($"There are {count} eggs.");
              }
              else
              {
                     Console.WriteLine("I could not parse the input.");
              }
              Console.WriteLine("Before parsing");
              Console.Write("What is your age? ");
              string input2 = Console.ReadLine();
              try
              {
                     int age2 = int.Parse(input2);
                     Console.WriteLine($"You are {age2} years old.");
              }
              //catch specific exception
              catch (FormatException)
              {
                     Console.WriteLine("The age you entered is not a valid number format.");
              }
              //this still would catch the above exception, and using the methods available to exceptions
              catch (Exception ex)
              {
                     Console.WriteLine($"{ex.GetType()} says {ex.Message}");
              }
              Console.WriteLine("After parsing");

       }
}

