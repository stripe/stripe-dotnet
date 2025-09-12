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
    /// Receive and process thin events like the v1.billing.meter.error_report_triggered event.
    ///
    /// In this example, we:
    ///   - use parseThinEvent to parse the received thin event webhook body
    ///   - call StripeClient.v2.core.events.retrieve to retrieve the full event object
    ///   - if it is a V1BillingMeterErrorReportTriggeredEvent event type, call fetchRelatedObject
    ///     to retrieve the Billing Meter object associated with the event.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ThinEventWebhookHandler : ControllerBase
    {
        private readonly StripeClient _client;
        private readonly string _webhookSecret;

        public ThinEventWebhookHandler()
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
                var thinEvent = _client.ParseEventNotification(json, Request.Headers["Stripe-Signature"], _webhookSecret);

                // Fetch the event data to understand the failure
                var baseEvent = await _client.V2.Core.Events.GetAsync(thinEvent.Id);
                if (baseEvent is V1BillingMeterErrorReportTriggeredEvent fullEvent)
                {
                    var meter = await fullEvent.FetchRelatedObjectAsync();
                    var meterId = meter.Id;

                    // Record the failures and alert your team
                    // Add your logic here
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
