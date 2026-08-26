// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxExemptionCa : StripeEntity<CustomerTaxExemptionCa>
    {
        /// <summary>
        /// Two-letter Canadian province code (ISO 3166-2). Null for country-wide GST/HST
        /// exemptions.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The type of Canadian tax (gst_hst, PST, QST, RST).
        /// </summary>
        [JsonProperty("tax_type")]
        [STJS.JsonPropertyName("tax_type")]
        public string TaxType { get; set; }
    }
}
