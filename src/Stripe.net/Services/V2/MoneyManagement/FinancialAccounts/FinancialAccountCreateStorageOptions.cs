// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountCreateStorageOptions : INestedOptions
    {
        /// <summary>
        /// The usage type for funds in this FinancialAccount. Can be used to specify that the funds
        /// are for Consumer activity.
        /// One of: <c>business</c>, or <c>consumer</c>.
        /// </summary>
        [JsonProperty("funds_usage_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funds_usage_type")]
#endif
        public string FundsUsageType { get; set; }

        /// <summary>
        /// The currencies that this FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public List<string> HoldsCurrencies { get; set; }
    }
}
