// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsShipping : StripeEntity<PaymentIntentAmountDetailsShipping>
    {
        /// <summary>
        /// Portion of the amount that is for shipping.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The postal code that represents the shipping source.
        /// </summary>
        [JsonProperty("from_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_postal_code")]
#endif
        public string FromPostalCode { get; set; }

        /// <summary>
        /// The postal code that represents the shipping destination.
        /// </summary>
        [JsonProperty("to_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_postal_code")]
#endif
        public string ToPostalCode { get; set; }
    }
}
