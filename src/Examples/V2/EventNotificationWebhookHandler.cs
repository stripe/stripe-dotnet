namespace Examples.V2
{
#pragma warning disable SA1101 // Prefix local calls with this

    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Stripe;
    using Stripe.Events;
    using Stripe.V2;

    /// <summary>
    /// Receive and process EventNotifications like the v1.billing.meter.error_report_triggered event.
    ///
    /// In this example, we:
    ///   - use ParseEventNotification to parse the received event notification webhook body
    ///   - call StripeClient.v2.core.events.retrieve to retrieve the full event object
    ///   - if it is a V1BillingMeterErrorReportTriggeredEvent event type, call fetchRelatedObject
    ///     to retrieve the Billing Meter object associated with the event.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationWebhookHandler : ControllerBase
    {
        private readonly StripeClient _client;
        private readonly string _webhookSecret;

        public EventNotificationWebhookHandler()
        {
            var apiKey = Environment.GetEnvironmentVariable("STRIPE_API_KEY");
            _client = new StripeClient(apiKey);

            _webhookSecret = Environment.GetEnvironmentVariable("WEBHOOK_SECRET");
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                var eventNotification = _client.ParseEventNotification(json, Request.Headers["Stripe-Signature"], _webhookSecret);

                // match on the type of the class to determine what event you have
                if (eventNotification is V1BillingMeterErrorReportTriggeredEventNotification evt)
                {
                    // the related object is correctly typed
                    var meter = evt.FetchRelatedObject();
                    Console.WriteLine($"Default aggregation: {meter.DefaultAggregation}");

                    // can also fetch the full event to get the event data
                    var eventObj = evt.FetchEvent();
                    var eventData = eventObj.Data;
                    Console.WriteLine($"Err summary: {eventData.DeveloperMessageSummary}");
                }

                // check other types the SDK knows about
                // for event types that were released after this SDK was generated, check type
                else if (eventNotification is UnknownEventNotification unknownEvt)
                {
                    // fall back to checking type
                    if (unknownEvt.Type == "some.other.event")
                    {
                        // handle the event
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
