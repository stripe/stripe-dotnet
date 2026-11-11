// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Supply the SEPA Creditor Identifier configured for the intended debit with your selected
        /// processor. Obtain it from your processor's SEPA configuration API or onboarding/support
        /// information. Do not supply a statement descriptor, IBAN, processor merchant-account ID,
        /// or mandate reference. If the creditor identifier is unknown, omit it.
        /// </summary>
        [JsonProperty("creditor_id")]
        [STJS.JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }

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
        /// Describes whether this payment is one-off or recurring.
        /// One of: <c>one_off</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("payment_type")]
        [STJS.JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }
    }
}
