// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RewardProgramRuleConditionCardSpendMerchantCategoryCodes : StripeEntity<RewardProgramRuleConditionCardSpendMerchantCategoryCodes>
    {
        /// <summary>
        /// Four-digit Merchant Category Codes to explicitly exclude. Takes precedence over
        /// <c>included</c>.
        /// </summary>
        [JsonProperty("excluded")]
        [STJS.JsonPropertyName("excluded")]
        public List<string> Excluded { get; set; }

        /// <summary>
        /// Four-digit Merchant Category Codes to include. An empty list matches all MCCs.
        /// </summary>
        [JsonProperty("included")]
        [STJS.JsonPropertyName("included")]
        public List<string> Included { get; set; }
    }
}
