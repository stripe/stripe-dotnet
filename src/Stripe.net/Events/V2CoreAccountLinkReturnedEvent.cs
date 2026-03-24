// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when the generated AccountLink is completed.
    /// </summary>
    public class V2CoreAccountLinkReturnedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.account_link.returned event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreAccountLinkReturnedEventData Data { get; set; }


    }
}
