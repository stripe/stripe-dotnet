namespace Examples.V2
{
#pragma warning disable SA1101 // Prefix local calls with this

    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Stripe;
    using Stripe.Events;

    /// <summary>
    /// receive and process event notifications (AKA thin events) like "v1.billing.meter.no_meter_found" using EventNotificationHandler.
    ///
    /// In this example, we:
    ///     - write a fallback callback to handle unrecognized event notifications
    ///     - create a StripeClient called client
    ///     - Initialize an EventNotificationHandler with the client, webhook secret, and fallback callback
    ///     - register a specific handler for the "v1.billing.meter.no_meter_found" event notification type
    ///     - use handler.handle() to process the received notification webhook body.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationHandlerEndpoint : ControllerBase
    {
        private readonly StripeClient client;
        private readonly StripeEventNotificationHandler handler;

        public EventNotificationHandlerEndpoint()
        {
            client = new StripeClient(Environment.GetEnvironmentVariable("STRIPE_API_KEY"));
            handler = client.NotificationHandler(Environment.GetEnvironmentVariable("WEBHOOK_SECRET") ?? string.Empty, FallbackCallback);

            // register handlers
            handler.V1BillingMeterErrorReportTriggered += HandleBillingMeterErrorReportTriggeredEventNotification;
        }

        private void HandleBillingMeterErrorReportTriggeredEventNotification(object sender, Stripe.StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification> e)
        {
            var meter = e.EventNotification.FetchRelatedObject();
            Console.WriteLine($"Meter {meter.DisplayName} had an error");
        }

        private void FallbackCallback(object sender, Stripe.StripeUnhandledEventNotificationEventArgs e)
        {
            Console.WriteLine($"Received unhandled event notification type: {e.EventNotification.Type}");
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            handler.Handle(json, Request.Headers["Stripe-Signature"]);
            return null;
        }
    }
}
