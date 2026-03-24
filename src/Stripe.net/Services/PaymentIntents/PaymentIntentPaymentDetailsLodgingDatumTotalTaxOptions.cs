// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumTotalTaxOptions : INestedOptions
    {
        /// <summary>
        /// Indicates whether the transaction is tax exempt.
        /// </summary>
        [JsonProperty("tax_exempt_indicator")]
        [STJS.JsonPropertyName("tax_exempt_indicator")]
        public bool? TaxExemptIndicator { get; set; }

        /// <summary>
        /// Tax details.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<PaymentIntentPaymentDetailsLodgingDatumTotalTaxTaxOptions> Taxes { get; set; }
    }
}
