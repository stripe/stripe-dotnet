// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCardOvercapture : StripeEntity<ChargePaymentMethodDetailsCardOvercapture>
    {
        /// <summary>
        /// The maximum amount that can be captured.
        /// </summary>
        [JsonProperty("maximum_amount_capturable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_amount_capturable")]
#endif
        public long MaximumAmountCapturable { get; set; }

        /// <summary>
        /// Indicates whether or not the authorized amount can be over-captured.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
