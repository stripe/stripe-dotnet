// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The generated account link has been completed.
    /// </summary>
    public class V2CoreAccountLinkCompletedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.account_link.completed event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreAccountLinkCompletedEventData Data { get; set; }
    }
}
