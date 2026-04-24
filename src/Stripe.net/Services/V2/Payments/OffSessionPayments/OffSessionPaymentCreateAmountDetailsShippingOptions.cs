// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateAmountDetailsShippingOptions : INestedOptions
    {
        /// <summary>
        /// Portion of the amount that is for shipping.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The postal code that represents the shipping source.
        /// </summary>
        [JsonProperty("from_postal_code")]
        [STJS.JsonPropertyName("from_postal_code")]
        public string FromPostalCode { get; set; }

        /// <summary>
        /// The postal code that represents the shipping destination.
        /// </summary>
        [JsonProperty("to_postal_code")]
        [STJS.JsonPropertyName("to_postal_code")]
        public string ToPostalCode { get; set; }
    }
}
