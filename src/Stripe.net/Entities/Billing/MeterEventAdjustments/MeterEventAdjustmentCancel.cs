// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterEventAdjustmentCancel : StripeEntity<MeterEventAdjustmentCancel>
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier")]
#endif

        public string Identifier { get; set; }
    }
}
