namespace Examples.V2
{
#pragma warning disable SA1101 // Prefix local calls with this

    using System;
    using System.Collections.Generic;
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
    ///     - set a PreHandle hook that deduplicates events by id before any callback runs
    ///     - register a specific handler for the "v1.billing.meter.no_meter_found" event notification type
    ///     - use handler.handle() to process the received notification webhook body.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationHandlerEndpoint : ControllerBase
    {
        private readonly StripeClient client;
        private readonly StripeEventNotificationHandler handler;

        // Handles events delivered through a channel that has already authenticated them, such as
        // AWS EventBridge or Azure Event Grid. Those payloads carry no Stripe-Signature header, so
        // this handler skips verification. Callbacks are registered separately from the one above.
        private readonly StripeEventNotificationHandlerWithoutVerification unverifiedHandler;

        // Webhooks can be delivered more than once, so we track ids we've already
        // processed. In production, back this with something durable and shared
        // across processes (e.g. Redis or a database table) instead of an in-memory HashSet.
        private readonly HashSet<string> processedEventIds = new HashSet<string>();

        public EventNotificationHandlerEndpoint()
        {
            client = new StripeClient(Environment.GetEnvironmentVariable("STRIPE_API_KEY"));
            handler = client.NotificationHandler(Environment.GetEnvironmentVariable("WEBHOOK_SECRET") ?? string.Empty, FallbackCallback);
            unverifiedHandler = client.NotificationHandlerWithoutVerification(FallbackCallback);

            // PreHandle runs after Handle parses the payload but before any callback fires.
            // Returning false skips both the registered handler and the fallback for this event.
            handler.PreHandle = SkipAlreadyProcessedEvents;
            unverifiedHandler.PreHandle = SkipAlreadyProcessedEvents;

            // can be anywhere in your codebase
            handler.V1BillingMeterErrorReportTriggered += HandleBillingMeterErrorReportTriggeredEventNotification;
            unverifiedHandler.V1BillingMeterErrorReportTriggered += HandleBillingMeterErrorReportTriggeredEventNotification;
        }

        /// <summary>
        /// Runs before any registered callback. Returning <c>false</c> here skips handling
        /// entirely for this delivery, which is useful for deduplicating webhooks.
        /// </summary>
        private bool SkipAlreadyProcessedEvents(Stripe.V2.Core.EventNotification eventNotification, StripeClient scopedClient)
        {
            // HashSet<T>.Add returns false if the item was already present, so this both records
            // the event and tells us whether we've seen it before in a single call.
            return processedEventIds.Add(eventNotification.Id);
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
            return Ok();
        }

        [HttpPost("from-cloud-provider")]
        public async Task<IActionResult> FromCloudProvider()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            // Handle takes only the body here; there's no signature to check
            unverifiedHandler.Handle(json);
            return Ok();
        }
    }
}
