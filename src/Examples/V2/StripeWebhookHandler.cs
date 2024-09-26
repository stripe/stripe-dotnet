#pragma warning disable SA1649 // File name should match first type name
#pragma warning disable SA1101 // Prefix local calls with this

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Events;

[Route("api/[controller]")]
[ApiController]
public class WebhookController : ControllerBase
{
    private readonly StripeClient _client;
    private readonly string _webhookSecret;

    public WebhookController()
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
            var thinEvent = _client.ParseThinEvent(json, Request.Headers["Stripe-Signature"], _webhookSecret);

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
