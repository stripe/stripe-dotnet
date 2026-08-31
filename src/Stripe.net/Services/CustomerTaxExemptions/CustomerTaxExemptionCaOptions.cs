// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerTaxExemptionCaOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter Canadian province code (ISO 3166-2). Required when tax_type is pst, qst, or
        /// rst.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The type of Canadian tax (gst_hst, PST, QST, RST).
        /// One of: <c>gst_hst</c>, <c>pst</c>, <c>qst</c>, or <c>rst</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("tax_type")]
        [STJS.JsonPropertyName("tax_type")]
        public string TaxType { get; set; }
    }
}
