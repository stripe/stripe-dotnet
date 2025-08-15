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
///   - use ParseThinEvent__Experimental to parse the received thin event webhook body into a PushedEvent
///   - if it is a ParsedV1BillingMeterErrorReportTriggeredEvent event type, call PullAsync to get
///     the V1BillingMeterErrorReportTriggeredEvent object
///   - call FetchRelatedObjectAsync on the pushed event to retrieve the Billing Meter object associated with the event.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class PushedEventWebhookHandler : ControllerBase
{
    private readonly StripeClient _client;
    private readonly string _webhookSecret;

    public PushedEventWebhookHandler()
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
            var pushedEvent = _client.ParseThinEvent__Experimental(json, Request.Headers["Stripe-Signature"], _webhookSecret);
            if (pushedEvent is PushedV1BillingMeterErrorReportTriggeredEvent pushedV1BillingEvent)
            {
                var pulledEvent = await pushedV1BillingEvent.PullAsync();
                var meter = await pushedV1BillingEvent.FetchRelatedObjectAsync();
                var meterId = meter.Id;
            }

            return Ok();
        }
        catch (StripeException e)
        {
            return BadRequest(e.Message);
        }
    }
}
