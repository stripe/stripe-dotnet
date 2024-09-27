namespace Examples
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.V2.Billing;

    public class NewExample
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
