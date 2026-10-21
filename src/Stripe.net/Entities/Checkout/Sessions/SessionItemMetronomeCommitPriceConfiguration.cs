// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitPriceConfiguration : StripeEntity<SessionItemMetronomeCommitPriceConfiguration>
    {
        /// <summary>
        /// The currency for this commit purchase, as an ISO 4217 lowercase string (for example,
        /// <c>usd</c>).
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Specifies whether the price is considered inclusive or exclusive of taxes. When omitted
        /// and automatic tax is enabled, uses <c>tax_settings.defaults.tax_behavior</c>. If no
        /// default is set, the request returns an error.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
