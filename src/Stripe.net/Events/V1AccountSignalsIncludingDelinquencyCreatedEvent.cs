// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a delinquency signal is created for an account.
    /// </summary>
    public class V1AccountSignalsIncludingDelinquencyCreatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v1.account_signals[delinquency].created event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V1AccountSignalsIncludingDelinquencyCreatedEventData Data { get; set; }
    }
}
