// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsCard : StripeEntity<PaymentEvaluationPaymentDetailsMoneyMovementDetailsCard>
    {
        /// <summary>
        /// Describes the presence of the customer during the payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("customer_presence")]
        [STJS.JsonPropertyName("customer_presence")]
        public string CustomerPresence { get; set; }

        /// <summary>
        /// Describes the type of payment.
        /// One of: <c>one_off</c>, <c>recurring</c>, <c>setup_one_off</c>, or
        /// <c>setup_recurring</c>.
        /// </summary>
        [JsonProperty("payment_type")]
        [STJS.JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }
    }
}
