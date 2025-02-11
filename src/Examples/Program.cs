﻿namespace Examples
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    public class Program
    {
        public Program()
        {
        }

        /// <summary>
        /// To create an example, clone NewExample.cs, implement the example
        /// copy this line and replace the class name with your new class.
        /// await NewExample.Run();
        /// e.g.
        /// await MeterEventExample.Run();
        /// then build the project and run bin/Debug/net8.0/Examples.
        ///
        /// </summary>
        /// <param name="args">command line args</param>
        /// <returns></returns>
        public static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: dotnet run --project Examples <name_of_example>");
                Environment.Exit(1);
                return;
            }

            var type = Assembly.GetExecutingAssembly().GetType($"Examples.{args[0]}");

            if (type == null)
            {
                Console.WriteLine($"Unable to find example class {args[0]}");
                Environment.Exit(1);
                return;
            }

            var runMethod = type.GetMethod(
                "Run",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (runMethod == null)
            {
                Console.WriteLine($"Example class {args[0]} is missing Run method");
                Environment.Exit(1);
                return;
            }

            Task? result = (Task?)runMethod.Invoke(null, null);
            if (result == null)
            {
                Console.WriteLine($"Unable to invoke Run method on {args[0]}");
                Environment.Exit(1);
                return;
            }

            await result;
        }
    }
}
