// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumTotalTax : StripeEntity<PaymentIntentPaymentDetailsFlightDatumTotalTax>
    {
        /// <summary>
        /// Tax details.
        /// </summary>
        [JsonProperty("tax_items")]
        [STJS.JsonPropertyName("tax_items")]
        public List<PaymentIntentPaymentDetailsFlightDatumTotalTaxTaxItem> TaxItems { get; set; }
    }
}
