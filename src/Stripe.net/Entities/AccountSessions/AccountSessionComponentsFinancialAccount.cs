// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsFinancialAccount : StripeEntity<AccountSessionComponentsFinancialAccount>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        public AccountSessionComponentsFinancialAccountFeatures Features { get; set; }
    }
}
