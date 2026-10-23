// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleUpdateRewardCashbackOptions : INestedOptions
    {
        /// <summary>
        /// Cashback rate as a percentage, represented as a decimal string. For example, <c>"2"</c>
        /// represents 2% and <c>"1.5"</c> represents 1.5%. Must be greater than <c>"0"</c> and less
        /// than or equal to <c>"100"</c>.
        /// </summary>
        [JsonProperty("rate")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("rate")]
        public decimal? Rate { get; set; }
    }
}
