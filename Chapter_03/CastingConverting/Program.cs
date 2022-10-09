using static System.Convert;

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

       }
}

