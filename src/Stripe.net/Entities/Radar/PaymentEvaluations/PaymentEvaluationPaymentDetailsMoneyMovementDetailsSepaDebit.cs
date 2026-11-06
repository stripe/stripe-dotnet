// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsSepaDebit : StripeEntity<PaymentEvaluationPaymentDetailsMoneyMovementDetailsSepaDebit>
    {
        /// <summary>
        /// Creditor identifier used for the intended debit.
        /// </summary>
        [JsonProperty("creditor_id")]
        [STJS.JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }
    }
}
