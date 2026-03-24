// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStorage : StripeEntity<FinancialAccountStorage>
    {
        /// <summary>
        /// The usage type for funds in this FinancialAccount. Can be used to specify that the funds
        /// are for Consumer activity.
        /// One of: <c>business</c>, or <c>consumer</c>.
        /// </summary>
        [JsonProperty("funds_usage_type")]
        [STJS.JsonPropertyName("funds_usage_type")]
        public string FundsUsageType { get; set; }

        /// <summary>
        /// The currencies that this FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}
