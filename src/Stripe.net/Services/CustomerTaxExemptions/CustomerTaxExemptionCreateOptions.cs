// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerTaxExemptionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Canada-specific exemption details. Required when country is CA; must be absent
        /// otherwise.
        /// </summary>
        [JsonProperty("ca")]
        [STJS.JsonPropertyName("ca")]
        public CustomerTaxExemptionCaOptions Ca { get; set; }

        /// <summary>
        /// Two-letter ISO country code for the exemption location.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// ISO 8601 date (YYYY-MM-DD) when the exemption becomes effective. Must be no more than
        /// one year after today's UTC date (inclusive).
        /// </summary>
        [JsonProperty("effective_date")]
        [STJS.JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// ISO 8601 date (YYYY-MM-DD) when the exemption expires.
        /// </summary>
        [JsonProperty("expiration_date")]
        [STJS.JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// US-specific exemption details. Required when country is US; must be absent otherwise.
        /// </summary>
        [JsonProperty("us")]
        [STJS.JsonPropertyName("us")]
        public CustomerTaxExemptionUsOptions Us { get; set; }
    }
}
