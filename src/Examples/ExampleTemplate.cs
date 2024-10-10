namespace Examples
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    ///
    /// This is a template for defining new examples.  It is not intended to be used directly.
    ///
    /// <describe what this example does>
    ///
    /// In this example, we:
    ///   - <key step 1>
    ///   - <key step 2
    ///   - ...
    ///
    /// <describe assumptions about the user's stripe account, environment, or configuration;
    /// or things to watch out for when running>
    /// </summary>
    public class ExampleTemplate
    {
        public static async Task Run()
        {
            var apiKey = "{{API_KEY}}";

            try
            {
                Console.WriteLine("Hello World");

                // var client = new StripeClient(apiKey);
                // client.V1...
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
