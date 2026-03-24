// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteSubscriptionDataOverrideBillingScheduleBillFromLineStartsAtOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of a quote line.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The position of the previous quote line in the <c>lines</c> array after which this line
        /// should begin. Indexes start from 0 and must be less than the index of the current line
        /// in the array.
        /// </summary>
        [JsonProperty("index")]
        [STJS.JsonPropertyName("index")]
        public long? Index { get; set; }
    }
}
