namespace Examples
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
        /// To create an example, clone ExampleTemplate.cs, implement the example
        /// copy this line and replace the class name with your new class.
        ///
        /// To run an example from this folder, execute:
        ///   dotnet run --project Examples.csproj NameOfExample
        ///
        /// The name of the example should include any namespace parts other than "Examples"
        /// which is prepended when looking up the type, for example"
        ///   dotnet run --project Examples.csproj <see cref="ExampleTemplate"/>
        /// or
        ///   dotnet run --project Examples.csproj <see cref="V2.MeterEventStream"/>.
        ///
        /// Examples accept configuration via environment variables, so ensure all environment vars
        /// are set before running the example.
        ///
        /// </summary>
        /// <param name="args">command line args.</param>
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
