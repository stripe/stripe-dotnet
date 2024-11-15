// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationListOptions : V2.ListOptions
    {
        /// <summary>
        /// Additional fields to include in the response. Currently supports
        /// <c>webhook_endpoint.url</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif

        public List<string> Include { get; set; }

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
