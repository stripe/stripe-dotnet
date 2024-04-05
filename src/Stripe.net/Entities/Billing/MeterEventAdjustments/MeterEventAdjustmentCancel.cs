// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterEventAdjustmentCancel : StripeEntity<MeterEventAdjustmentCancel>
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
