// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestRequestedBy : StripeEntity<ApprovalRequestRequestedBy>
    {
        /// <summary>
        /// Present when <c>type</c> is <c>api_key</c>.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public ApprovalRequestRequestedByApiKey ApiKey { get; set; }

        /// <summary>
        /// The type of actor that made the request.
        /// One of: <c>api_key</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Present when <c>type</c> is <c>user</c>.
        /// </summary>
        [JsonProperty("user")]
        [STJS.JsonPropertyName("user")]
        public ApprovalRequestRequestedByUser User { get; set; }
    }
}
