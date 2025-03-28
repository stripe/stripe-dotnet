// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceTotalTaxTaxRateDetails : StripeEntity<InvoiceTotalTaxTaxRateDetails>
    {
        [JsonProperty("tax_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rate")]
#endif
        public string TaxRate { get; set; }
    }
}
