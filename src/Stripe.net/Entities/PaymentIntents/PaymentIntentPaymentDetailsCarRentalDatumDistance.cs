// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumDistance : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDistance>
    {
        /// <summary>
        /// Distance amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Unit for the distance.
        /// One of: <c>kilometers</c>, or <c>miles</c>.
        /// </summary>
        [JsonProperty("unit")]
        [STJS.JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
