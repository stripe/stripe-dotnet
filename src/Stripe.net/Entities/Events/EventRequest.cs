// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventRequest : StripeEntity<EventRequest>, IHasId
    {
        /// <summary>
        /// ID of the API request that caused the event. If null, the event was automatic (e.g.,
        /// Stripe's automatic subscription handling). Request logs are available in the <a
        /// href="https://dashboard.stripe.com/logs">dashboard</a>, but currently not in the API.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The idempotency key transmitted during the request, if any. <em>Note: This property is
        /// populated only for events on or after May 23, 2017</em>.
        /// </summary>
        [JsonProperty("idempotency_key")]
        [STJS.JsonPropertyName("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
