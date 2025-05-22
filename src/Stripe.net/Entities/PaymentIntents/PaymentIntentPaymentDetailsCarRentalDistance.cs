// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDistance : StripeEntity<PaymentIntentPaymentDetailsCarRentalDistance>
    {
        /// <summary>
        /// Distance traveled.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Unit of measurement for the distance traveled. One of <c>miles</c> or <c>kilometers</c>.
        /// </summary>
        [JsonProperty("unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit")]
#endif
        public string Unit { get; set; }
    }
}
