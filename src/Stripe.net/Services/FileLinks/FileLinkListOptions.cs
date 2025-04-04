// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FileLinkListOptions : ListOptions
    {
        /// <summary>
        /// Only return links that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Filter links by their expiration status. By default, Stripe returns all links.
        /// </summary>
        [JsonProperty("expired")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expired")]
#endif
        public bool? Expired { get; set; }

        /// <summary>
        /// Only return links for the given file.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public string File { get; set; }
    }
}
