// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumTotalTaxTax : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumTotalTaxTax>
    {
        /// <summary>
        /// Tax amount.
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
        /// Type of tax.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
