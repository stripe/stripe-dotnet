// File copied from our code generator; changes here will be overwritten.
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    ///  The non-StripeEntity version of a ReasonRequest.
    /// </summary>
    public class EventNotificationReasonRequest
    {
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
