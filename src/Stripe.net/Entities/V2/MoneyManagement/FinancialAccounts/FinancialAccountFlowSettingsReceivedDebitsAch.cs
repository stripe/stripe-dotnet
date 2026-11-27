// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFlowSettingsReceivedDebitsAch : StripeEntity<FinancialAccountFlowSettingsReceivedDebitsAch>
    {
        /// <summary>
        /// Whether ACH received debits are enabled. Defaults to true. Other restrictions still
        /// apply.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Controls whether ACH debits without a matching active SpendingMandate are allowed or
        /// rejected Defaults to <c>optional</c>. Other restrictions still apply.
        /// One of: <c>optional</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("mandate_behavior")]
        [STJS.JsonPropertyName("mandate_behavior")]
        public string MandateBehavior { get; set; }

        /// <summary>
        /// Account-level per-debit limit. Set to null to clear the limit.
        /// </summary>
        [JsonProperty("transaction_limit")]
        [STJS.JsonPropertyName("transaction_limit")]
        public V2.Amount TransactionLimit { get; set; }
    }
}
