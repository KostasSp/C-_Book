using System.Linq;
using System.Reflection;

#nullable enable

namespace Chapter2
{
       class Address
       {
              public string? Building;
              public string Street = string.Empty;
              public string? City = string.Empty;
              public string? Region = string.Empty;
       }

       class Program
       {
              static void Main(string[] args)
              {
                     System.Data.DataSet ds;
                     System.Net.Http.HttpClient client;
                     var address = new Address();
                     address.Building = null;
                     address.Street = null;
                     address.City = "London";
                     address.Region = null;
                     // result will be 3 if authorName?.Length is null

                     object height = 1.88; // storing a double in an object
                     object name = "Amir"; // storing a string in an object
                     Console.WriteLine($"{name} is {height} metres tall.");
                     //int length1 = name.Length; // gives compile error!
                     int length2 = ((string)name).Length; // tell compiler it is a string
                     Console.WriteLine($"{name} has {length2} characters.");
                     Console.WriteLine("Using decimals:");
                     dynamic anotherName = "Ahmed";
                     Console.WriteLine(anotherName.Length);
                     Console.WriteLine($"default(int) = {default(int)}");
                     Console.WriteLine($"default(bool) = {default(bool)}");
                     Console.WriteLine($"default(DateTime) = {default(DateTime)}");
                     Console.WriteLine($"default(string) = {default(string)}");
                     string[] names;
                     names = new string[5];
                     names[0] = "Kate";
                     names[1] = "Jack";
                     names[2] = "Rebecca";
                     names[3] = "Tom";
                     foreach (string i in names)
                     {
                            Console.WriteLine(i);
                     }
                     int? thisCouldBeNull = null;
                     Console.WriteLine(thisCouldBeNull);
                     Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
                     thisCouldBeNull = 7;
                     Console.WriteLine(thisCouldBeNull);
                     Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
                     //StreamWriter file2 = File.CreateText(@"C:\something.txt");
                     decimal c = 0.1M; // M suffix means a decimal literal value
                     decimal d = 0.2M;
                     if (c + d == 0.3M)
                     {
                            Console.WriteLine($"{c} + {d} equals 0.3");
                     }
                     else
                     {
                            Console.WriteLine($"{c} + {d} does NOT equal 0.3");
                     }
                     Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
                     Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
                     Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
                     // loop through the assemblies that this app references 
                     foreach (var r in Assembly.GetEntryAssembly()
                      .GetReferencedAssemblies())
                     {
                            // load the assembly so we can read its details
                            var a = Assembly.Load(new AssemblyName(r.FullName));
                            // declare a variable to count the number of methods
                            int methodCount = 0;
                            // loop through all the types in the assembly
                            foreach (var t in a.DefinedTypes)
                            {
                                   // add up the counts of methods
                                   methodCount += t.GetMethods().Count();
                            }
                            // output the count of types and their methods
                            Console.WriteLine(
                            "{0:N0} types with {1:N0} methods in {2} assembly.",
                            arg0: a.DefinedTypes.Count(),
                            arg1: methodCount,
                            arg2: r.Name);
                     }
              }
       }
}
