// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillForOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether to debit for accrued metered usage in the current billing period. The
        /// default is <c>true</c>.
        /// </summary>
        [JsonProperty("outstanding_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outstanding_usage")]
#endif
        public bool? OutstandingUsage { get; set; }

        /// <summary>
        /// Controls whether to credit for licensed items in the current billing period. The default
        /// is <c>true</c>.
        /// </summary>
        [JsonProperty("unused_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unused_time")]
#endif
        public bool? UnusedTime { get; set; }
    }
}
