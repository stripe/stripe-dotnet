// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilLineStartsAtOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of a quote line.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The position of the previous quote line in the <c>lines</c> array after which this line
        /// should begin. Indexes start from 0 and must be less than the index of the current line
        /// in the array.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }
    }
}
