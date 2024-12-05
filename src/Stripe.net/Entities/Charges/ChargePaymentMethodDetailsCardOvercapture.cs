// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardOvercapture : StripeEntity<ChargePaymentMethodDetailsCardOvercapture>
    {
        /// <summary>
        /// The maximum amount that can be captured.
        /// </summary>
        [JsonProperty("maximum_amount_capturable")]
        public long MaximumAmountCapturable { get; set; }

        /// <summary>
        /// Indicates whether or not the authorized amount can be over-captured.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
