// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Describes the presence of the customer during the payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("customer_presence")]
        [STJS.JsonPropertyName("customer_presence")]
        public string CustomerPresence { get; set; }

        /// <summary>
        /// Describes the type of US bank account payment.
        /// One of: <c>one_off</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("payment_type")]
        [STJS.JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }
    }
}
