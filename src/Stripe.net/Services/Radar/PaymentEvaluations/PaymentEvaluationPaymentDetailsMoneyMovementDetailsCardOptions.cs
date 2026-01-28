// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsCardOptions : INestedOptions
    {
        /// <summary>
        /// Describes the presence of the customer during the payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("customer_presence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_presence")]
#endif
        public string CustomerPresence { get; set; }

        /// <summary>
        /// Describes the type of payment.
        /// One of: <c>one_off</c>, <c>recurring</c>, <c>setup_one_off</c>, or
        /// <c>setup_recurring</c>.
        /// </summary>
        [JsonProperty("payment_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_type")]
#endif
        public string PaymentType { get; set; }
    }
}
