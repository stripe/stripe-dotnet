// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when the generated AccountLink is completed.
    /// </summary>
    public class V2CoreAccountLinkReturnedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.account_link.returned event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreAccountLinkReturnedEventData Data { get; set; }
    }
}
