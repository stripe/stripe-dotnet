// File generated from our OpenAPI spec
namespace Stripe.Orchestration
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Represents orchestration information for a payment attempt record (e.g. return url).
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttempt : StripeEntity<PaymentAttempt>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// If present, the return URL for this payment attempt.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
