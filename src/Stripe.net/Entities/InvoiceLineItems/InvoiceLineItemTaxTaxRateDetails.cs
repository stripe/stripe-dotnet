// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemTaxTaxRateDetails : StripeEntity<InvoiceLineItemTaxTaxRateDetails>
    {
        /// <summary>
        /// ID of the tax rate.
        /// </summary>
        [JsonProperty("tax_rate")]
        [STJS.JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }
    }
}
