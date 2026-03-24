// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Fraudulent Website signal is ready for an account.
    /// </summary>
    public class V2CoreAccountSignalsFraudulentWebsiteReadyEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.account_signals.fraudulent_website_ready event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreAccountSignalsFraudulentWebsiteReadyEventData Data { get; set; }
    }
}
