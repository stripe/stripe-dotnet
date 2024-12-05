// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsCapitalFinancingApplication : StripeEntity<AccountSessionComponentsCapitalFinancingApplication>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        public AccountSessionComponentsCapitalFinancingApplicationFeatures Features { get; set; }
    }
}
