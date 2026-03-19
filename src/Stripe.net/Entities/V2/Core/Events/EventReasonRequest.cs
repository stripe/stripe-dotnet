// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventReasonRequest : StripeEntity<EventReasonRequest>, IHasId
    {
        /// <summary>
        /// The client details that made the request.
        /// </summary>
        [JsonProperty("client")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client")]
#endif
        public EventReasonRequestClient Client { get; set; }

        /// <summary>
        /// ID of the API request that caused the event.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The idempotency key transmitted during the request.
        /// </summary>
        [JsonProperty("idempotency_key")]
        [STJS.JsonPropertyName("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
