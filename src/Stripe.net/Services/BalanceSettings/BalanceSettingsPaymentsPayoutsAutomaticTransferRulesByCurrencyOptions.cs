// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceSettingsPaymentsPayoutsAutomaticTransferRulesByCurrencyOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the FinancialAccount that funds will be transferred to during automatic
        /// transfers.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// The maximum amount in minor units to transfer to the FinancialAccount. Required and only
        /// applicable when <c>type</c> is <c>transfer_up_to_amount</c>.
        /// </summary>
        [JsonProperty("transfer_up_to_amount")]
        [STJS.JsonPropertyName("transfer_up_to_amount")]
        public long? TransferUpToAmount { get; set; }

        /// <summary>
        /// The type of automatic transfer rule.
        /// One of: <c>transfer_all</c>, or <c>transfer_up_to_amount</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
