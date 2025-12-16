// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The idempotency key transmitted during the request.
        /// </summary>
        [JsonProperty("idempotency_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("idempotency_key")]
#endif
        public string IdempotencyKey { get; set; }
    }
}
