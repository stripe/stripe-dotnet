// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardOvercapture : StripeEntity<ChargePaymentMethodDetailsCardOvercapture>
    {
        /// <summary>
        /// The maximum amount that can be captured.
        /// </summary>
        [JsonProperty("maximum_amount_capturable")]
        [STJS.JsonPropertyName("maximum_amount_capturable")]
        public long MaximumAmountCapturable { get; set; }

        /// <summary>
        /// Indicates whether or not the authorized amount can be over-captured.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
