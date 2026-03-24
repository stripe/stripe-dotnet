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


    }
}
