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
        /// One of: <c>card</c>, or <c>us_bank_account</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details about the US bank account payment method.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentAttemptRecordPaymentMethodDetailsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
