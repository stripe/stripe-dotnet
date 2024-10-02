// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;

    public class MeterEventAdjustmentCreateCancelOptions : INestedOptions
    {
        /// <summary>
        /// Unique identifier for the event. You can only cancel events within 24 hours of Stripe
        /// receiving them.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
