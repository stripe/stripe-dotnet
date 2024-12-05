// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterEventAdjustmentCancelOptions : INestedOptions
    {
        /// <summary>
        /// Unique identifier for the event. You can only cancel events within 24 hours of Stripe
        /// receiving them.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
