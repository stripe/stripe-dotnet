// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerTaxExemptionListOptions : ListOptions
    {
        /// <summary>
        /// Filter by two-letter ISO country code (ISO 3166-1 alpha-2).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
