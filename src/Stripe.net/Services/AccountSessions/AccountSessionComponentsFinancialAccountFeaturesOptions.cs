// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsFinancialAccountFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow external accounts to be linked for money transfer.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool? ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow money movement features.
        /// </summary>
        [JsonProperty("money_movement")]
        public bool? MoneyMovement { get; set; }

        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        public bool? SendMoney { get; set; }

        /// <summary>
        /// Whether to allow transferring balance.
        /// </summary>
        [JsonProperty("transfer_balance")]
        public bool? TransferBalance { get; set; }
    }
}
