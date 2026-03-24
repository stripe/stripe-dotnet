// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumTotalTaxTax : StripeEntity<PaymentIntentPaymentDetailsLodgingDatumTotalTaxTax>
    {
        /// <summary>
        /// Tax amount in cents.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        [JsonProperty("rate")]
        [STJS.JsonPropertyName("rate")]
        public long Rate { get; set; }

        /// <summary>
        /// Type of tax applied.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
