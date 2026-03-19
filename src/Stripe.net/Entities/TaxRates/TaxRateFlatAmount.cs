// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxRateFlatAmount : StripeEntity<TaxRateFlatAmount>
    {
        /// <summary>
        /// Amount of the tax when the <c>rate_type</c> is <c>flat_amount</c>. This positive integer
        /// represents how much to charge in the smallest currency unit (e.g., 100 cents to charge
        /// $1.00 or 100 to charge ¥100, a zero-decimal currency). The amount value supports up to
        /// eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
