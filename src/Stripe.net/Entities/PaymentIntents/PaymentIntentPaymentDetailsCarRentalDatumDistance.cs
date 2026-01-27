// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumDistance : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDistance>
    {
        /// <summary>
        /// Distance amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Unit for the distance.
        /// One of: <c>kilometers</c>, or <c>miles</c>.
        /// </summary>
        [JsonProperty("unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit")]
#endif
        public string Unit { get; set; }
    }
}
