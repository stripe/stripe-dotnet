// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataBillOnAcceptanceBillFromLineStartsAtOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of a quote line.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The position of the previous quote line in the <c>lines</c> array after which this line
        /// should begin. Indexes start from 0 and must be less than the index of the current line
        /// in the array.
        /// </summary>
        [JsonProperty("index")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("index")]
#endif
        public long? Index { get; set; }
    }
}
