// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxExemptionEs : StripeEntity<CustomerTaxExemptionEs>
    {
        /// <summary>
        /// Two-letter Spanish subdivision code (ISO 3166-2). Absent for country-wide Spain
        /// exemptions.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
