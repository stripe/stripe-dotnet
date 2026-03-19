// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BatchJobCreateNotificationSuppressionOptions : INestedOptions
    {
        /// <summary>
        /// The scope of notification suppression.
        /// One of: <c>all</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
