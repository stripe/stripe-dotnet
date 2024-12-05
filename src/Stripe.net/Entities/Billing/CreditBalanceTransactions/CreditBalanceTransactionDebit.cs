// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceTransactionDebit : StripeEntity<CreditBalanceTransactionDebit>
    {
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CreditBalanceTransactionDebitAmount Amount { get; set; }

        /// <summary>
        /// Details of how the billing credits were applied to an invoice. Only present if
        /// <c>type</c> is <c>credits_applied</c>.
        /// </summary>
        [JsonProperty("credits_applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credits_applied")]
#endif
        public CreditBalanceTransactionDebitCreditsApplied CreditsApplied { get; set; }

        /// <summary>
        /// The type of debit transaction.
        /// One of: <c>credits_applied</c>, <c>credits_expired</c>, or <c>credits_voided</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
