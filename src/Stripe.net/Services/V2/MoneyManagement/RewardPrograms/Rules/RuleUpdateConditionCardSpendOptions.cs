// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleUpdateConditionCardSpendOptions : INestedOptions
    {
        /// <summary>
        /// Merchant Category Code include/exclude configuration. Omitted means the rule matches all
        /// MCCs.
        /// </summary>
        [JsonProperty("merchant_category_codes")]
        [STJS.JsonPropertyName("merchant_category_codes")]
        public RuleUpdateConditionCardSpendMerchantCategoryCodesOptions MerchantCategoryCodes { get; set; }
    }
}
