// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a fraudulent merchant signal is ready for an account.
    /// </summary>
    public class V2SignalsAccountSignalFraudulentMerchantReadyEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.signals.account_signal.fraudulent_merchant_ready event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2SignalsAccountSignalFraudulentMerchantReadyEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.Signals.AccountSignal> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Signals.AccountSignal>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Signals.AccountSignal FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Signals.AccountSignal>(this.RelatedObject);
        }
    }
}
