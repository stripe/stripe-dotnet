// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceTransactionDebit : StripeEntity<CreditBalanceTransactionDebit>
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public CreditBalanceTransactionDebitAmount Amount { get; set; }

        /// <summary>
        /// Details of how the billing credits were applied to an invoice. Only present if
        /// <c>type</c> is <c>credits_applied</c>.
        /// </summary>
        [JsonProperty("credits_applied")]
        [STJS.JsonPropertyName("credits_applied")]
        public CreditBalanceTransactionDebitCreditsApplied CreditsApplied { get; set; }

        /// <summary>
        /// The type of debit transaction.
        /// One of: <c>credits_applied</c>, <c>credits_expired</c>, or <c>credits_voided</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
