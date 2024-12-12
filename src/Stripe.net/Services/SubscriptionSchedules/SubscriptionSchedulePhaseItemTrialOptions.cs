// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhaseItemTrialOptions : INestedOptions
    {
        /// <summary>
        /// List of price IDs which, if present on the subscription following a paid trial,
        /// constitute opting-in to the paid trial. Currently only supports at most 1 price ID.
        /// </summary>
        [JsonProperty("converts_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("converts_to")]
#endif
        public List<string> ConvertsTo { get; set; }

        /// <summary>
        /// Determines the type of trial for this item.
        /// One of: <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
