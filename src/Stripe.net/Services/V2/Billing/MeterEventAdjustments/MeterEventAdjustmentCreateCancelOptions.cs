// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterEventAdjustmentCreateCancelOptions : INestedOptions
    {
        /// <summary>
        /// Unique identifier for the event. You can only cancel events within 24 hours of Stripe
        /// receiving them.
        /// </summary>
        [JsonProperty("identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier")]
#endif
        public string Identifier { get; set; }
    }
}
