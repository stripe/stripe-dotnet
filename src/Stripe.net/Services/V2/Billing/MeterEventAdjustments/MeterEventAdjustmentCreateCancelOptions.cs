// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterEventAdjustmentCreateCancelOptions : INestedOptions
    {
        /// <summary>
        /// Unique identifier for the event. You can only cancel events within 24 hours of Stripe
        /// receiving them.
        /// </summary>
        [JsonProperty("identifier")]
        [STJS.JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }
}
