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
    /// Receive and process EventNotifications like the v1.billing.meter.error_report_triggered event.
    ///
    /// In this example, we:
    ///   - use ParseEventNotification to parse the received event notification webhook body
    ///   - call StripeClient.v2.core.events.retrieve to retrieve the full event object
    ///   - if it is a V1BillingMeterErrorReportTriggeredEvent event type, call fetchRelatedObject
    ///     to retrieve the Billing Meter object associated with the event.
    ///   - handle unknown event types gracefully.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationWebhookHandler : ControllerBase
    {
        private readonly StripeClient client;
        private readonly string webhookSecret;

        public EventNotificationWebhookHandler()
        {
            var apiKey = Environment.GetEnvironmentVariable("STRIPE_API_KEY");
            client = new StripeClient(apiKey);

            webhookSecret = Environment.GetEnvironmentVariable("WEBHOOK_SECRET") ?? string.Empty;
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                var eventNotification = client.ParseEventNotification(json, Request.Headers["Stripe-Signature"], webhookSecret);

                // match on the type of the class to determine what event you have
                if (eventNotification is V1BillingMeterErrorReportTriggeredEventNotification notif)
                {
                    // there's basic info about the related object in the notification
                    Console.WriteLine(
                        $"Meter w/ id {notif.RelatedObject.Id} had a problem");

                    // or you can fetch the full object form the API for more details
                    var meter = await notif.FetchRelatedObjectAsync();
                    Console.WriteLine($"Meter {meter.DisplayName} ({meter.Id}) had a problem");

                    // And you can always fetch the full event:
                    var evt = await notif.FetchEventAsync();
                    Console.WriteLine($"More info: {evt.Data.DeveloperMessageSummary}");
                }
                else if (eventNotification is UnknownEventNotification unknownEvt)
                {
                    // this is a valid event type, but it's newer than this SDK, so there's no
                    // corresponding class.
                    // we'll have to match on "type" instead
                    if (unknownEvt.Type == "some.other.event")
                    {
                        // you can still `.fetchEvent()` and `.fetchRelatedObject()`, but the latter may
                        // return `null` if that event type doesn't have a related object.
                    }
                }

                return Ok();
            }
            catch (StripeException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
