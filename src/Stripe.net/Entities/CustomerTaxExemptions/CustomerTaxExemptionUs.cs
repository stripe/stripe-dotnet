// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxExemptionUs : StripeEntity<CustomerTaxExemptionUs>
    {
        /// <summary>
        /// Two-letter US state code (ISO 3166-2).
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The group of tax codes this exemption applies to. Exemptions created without one have
        /// <c>all</c>.
        /// One of: <c>all</c>, or <c>saas</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("tax_code_group")]
        [STJS.JsonPropertyName("tax_code_group")]
        public string TaxCodeGroup { get; set; }
    }
}
