namespace MeterEventExample
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.V2.Billing;

    public class MeterEventExample
    {
        private static MeterEventSession? meterEventSession;

        public static async Task Run()
        {
            var apiKey = "{{API_KEY}}";
            var customerId = "{{CUSTOMER_ID}}"; // Replace with actual customer ID

            try
            {
                await SendMeterEvent(apiKey, "alpaca_ai_tokens", customerId, "25");
                Console.WriteLine("Meter event sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending meter event: {ex.Message}");
            }
        }

        private static async Task RefreshMeterEventSession(string apiKey)
        {
            // Check if session is null or expired
            if (meterEventSession == null || meterEventSession.ExpiresAt <= DateTime.UtcNow)
            {
                // Create a new meter event session in case the existing session expired
                var client = new StripeClient(apiKey);
                meterEventSession = await client.V2.Billing.MeterEventSession.CreateAsync(new MeterEventSessionCreateOptions());
            }
        }

        private static async Task SendMeterEvent(string apiKey, string eventName, string stripeCustomerId, string value)
        {
            // Refresh the meter event session if necessary
            await RefreshMeterEventSession(apiKey);

            if (meterEventSession == null)
            {
                throw new Exception("Unable to refresh meter event session");
            }

            // Create a meter event
            var client = new StripeClient(meterEventSession.AuthenticationToken);
            var options = new MeterEventStreamCreateOptions
            {
                Events =
                [
                    new MeterEventStreamCreateEventOptions
                    {
                        EventName = eventName,
                        Payload = new Dictionary<string, string>
                    {
                        { "stripe_customer_id", stripeCustomerId },
                        { "value", value },
                    },
                    },
                ],
            };
            client.V2.Billing.MeterEventStream.Create(options);
        }
    }
}
