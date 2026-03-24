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
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<PaymentIntentPaymentDetailsFlightDatumTotalTaxTax> Taxes { get; set; }
    }
}
