// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsLink : StripeEntity<ChargePaymentMethodDetailsLink>
    {
        /// <summary>
        /// Two-letter ISO code representing the funding source country beneath the Link payment.
        /// You could use this attribute to get a sense of international fees.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The pricing bundle applied to this Link payment at confirmation time. Maps to a bundle
        /// in your Stripe pricing contract and on Stripe's published pricing page. Omitted if
        /// bundle lookup failed at confirmation time.
        /// </summary>
        [JsonProperty("pricing_group")]
        [STJS.JsonPropertyName("pricing_group")]
        public string PricingGroup { get; set; }
    }
}
