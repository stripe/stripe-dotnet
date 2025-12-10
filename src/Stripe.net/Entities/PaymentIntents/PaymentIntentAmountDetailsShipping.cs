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
        /// If a physical good is being shipped, the cost of shipping represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than or equal to 0.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// If a physical good is being shipped, the postal code of where it is being shipped from.
        /// At most 10 alphanumeric characters long, hyphens are allowed.
        /// </summary>
        [JsonProperty("from_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_postal_code")]
#endif
        public string FromPostalCode { get; set; }

        /// <summary>
        /// If a physical good is being shipped, the postal code of where it is being shipped to. At
        /// most 10 alphanumeric characters long, hyphens are allowed.
        /// </summary>
        [JsonProperty("to_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_postal_code")]
#endif
        public string ToPostalCode { get; set; }
    }
}
