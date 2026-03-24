// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LicensedItemTaxDetails : StripeEntity<LicensedItemTaxDetails>
    {
        /// <summary>
        /// Product tax code (PTC).
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
