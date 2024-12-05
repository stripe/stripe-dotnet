// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsCapitalFinancingPromotion : StripeEntity<AccountSessionComponentsCapitalFinancingPromotion>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        public AccountSessionComponentsCapitalFinancingPromotionFeatures Features { get; set; }
    }
}
