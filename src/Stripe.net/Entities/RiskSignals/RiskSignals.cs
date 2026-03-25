// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RiskSignals : StripeEntity<RiskSignals>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Represents the status of risk signal session metadata collection. When false, the
        /// account has payouts and payments disabled.
        /// </summary>
        [JsonProperty("session_metadata")]
        [STJS.JsonPropertyName("session_metadata")]
        public bool SessionMetadata { get; set; }
    }
}
