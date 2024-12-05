// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventReasonRequest : StripeEntity<EventReasonRequest>, IHasId
    {
        /// <summary>
        /// ID of the API request that caused the event.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The idempotency key transmitted during the request.
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
