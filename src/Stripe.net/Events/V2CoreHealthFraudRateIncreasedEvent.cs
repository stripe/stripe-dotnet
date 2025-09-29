// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when the fraud rate has increased.
    /// </summary>
    public class V2CoreHealthFraudRateIncreasedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.fraud_rate.increased event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthFraudRateIncreasedEventData Data { get; set; }
    }
}
