// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleUpdateRewardOptions : INestedOptions
    {
        /// <summary>
        /// Cashback reward configuration.
        /// </summary>
        [JsonProperty("cashback")]
        [STJS.JsonPropertyName("cashback")]
        public RuleUpdateRewardCashbackOptions Cashback { get; set; }
    }
}
