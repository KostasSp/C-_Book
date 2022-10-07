using static System.Console;

// int a = 3;
// int b = a++;
// WriteLine($"a is {a}, b is {b}");

public partial class Program
{
       private static void Main(string[] args)
       {
              int c = 3;
              int d = ++c; // increment c before assigning it
              WriteLine($"c is {c}, d is {d}");

              int f = 3;

              double g = 11.0;
              WriteLine($"g is {g:N2}, f is {f}");
              WriteLine($"g / f = {g / f}");

              bool a = true;
              bool b = false;
              WriteLine($"AND | a | b ");
              WriteLine($"a | {a & a,-5} | {a & b,-5} ");
              WriteLine($"b | {b & a,-5} | {b & b,-5} ");
              WriteLine();
              WriteLine($"OR | a | b ");
              WriteLine($"a | {a | a,-5} | {a | b,-5} ");
              WriteLine($"b | {b | a,-5} | {b | b,-5} ");
              WriteLine();
              WriteLine($"XOR | a | b ");
              WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
              WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
       }
}