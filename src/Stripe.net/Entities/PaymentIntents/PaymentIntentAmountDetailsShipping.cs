// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsShipping : StripeEntity<PaymentIntentAmountDetailsShipping>
    {
        /// <summary>
        /// If a physical good is being shipped, the cost of shipping represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than or equal to 0.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If a physical good is being shipped, the postal code of where it is being shipped from.
        /// At most 10 alphanumeric characters long, hyphens and spaces are allowed.
        /// </summary>
        [JsonProperty("from_postal_code")]
        [STJS.JsonPropertyName("from_postal_code")]
        public string FromPostalCode { get; set; }

        /// <summary>
        /// If a physical good is being shipped, the postal code of where it is being shipped to. At
        /// most 10 alphanumeric characters long, hyphens and spaces are allowed.
        /// </summary>
        [JsonProperty("to_postal_code")]
        [STJS.JsonPropertyName("to_postal_code")]
        public string ToPostalCode { get; set; }
    }
}
