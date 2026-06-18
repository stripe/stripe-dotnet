// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryElementsError : StripeEntity<AlertHistoryEntryElementsError>
    {
        /// <summary>
        /// The type of the element.
        /// One of: <c>expressCheckout</c>, or <c>payment</c>.
        /// </summary>
        [JsonProperty("element_type")]
        [STJS.JsonPropertyName("element_type")]
        public string ElementType { get; set; }

        /// <summary>
        /// The number of impacted sessions.
        /// </summary>
        [JsonProperty("impacted_sessions")]
        [STJS.JsonPropertyName("impacted_sessions")]
        public long ImpactedSessions { get; set; }
    }
}
