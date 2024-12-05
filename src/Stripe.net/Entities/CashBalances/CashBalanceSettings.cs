// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CashBalanceSettings : StripeEntity<CashBalanceSettings>
    {
        /// <summary>
        /// The configuration for how funds that land in the customer cash balance are reconciled.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("reconciliation_mode")]
        public string ReconciliationMode { get; set; }

        /// <summary>
        /// A flag to indicate if reconciliation mode returned is the user's default or is specific
        /// to this customer cash balance.
        /// </summary>
        [JsonProperty("using_merchant_default")]
        public bool UsingMerchantDefault { get; set; }
    }
}
