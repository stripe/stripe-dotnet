// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object_id")]
#endif

        public string ObjectId { get; set; }

        /// <summary>
        /// The requested page.
        /// </summary>
        [JsonProperty("page")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("page")]
#endif

        public string Page { get; set; }
    }
}
