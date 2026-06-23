// Stub — provides EventReasonRequest type referenced by EventReason.
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReasonRequest : StripeEntity<EventReasonRequest>, IHasId
    {
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        [JsonProperty("idempotency_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("idempotency_key")]
#endif
        public string IdempotencyKey { get; set; }
    }
}
