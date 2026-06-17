// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Information about the card payment method used to make this payment.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentAttemptRecordPaymentMethodDetailsCardOptions Card { get; set; }

        /// <summary>
        /// The type of the payment method details. An additional hash is included on the
        /// payment_method_details with a name matching this value. It contains additional
        /// information specific to the type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
