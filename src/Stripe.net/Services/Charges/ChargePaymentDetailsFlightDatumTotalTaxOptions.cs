// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFlightDatumTotalTaxOptions : INestedOptions
    {
        /// <summary>
        /// Array of tax details.
        /// </summary>
        [JsonProperty("tax_items")]
        [STJS.JsonPropertyName("tax_items")]
        public List<ChargePaymentDetailsFlightDatumTotalTaxTaxItemOptions> TaxItems { get; set; }
    }
}
