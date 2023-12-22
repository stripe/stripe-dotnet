// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsCapitalFinancingPromotionOptions : INestedOptions
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of features enabled in the embedded component.
        /// </summary>
        [JsonProperty("features")]
        public AccountSessionComponentsCapitalFinancingPromotionFeaturesOptions Features { get; set; }
    }
}
