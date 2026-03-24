// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FileLinkListOptions : ListOptions
    {
        /// <summary>
        /// Only return links that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Filter links by their expiration status. By default, Stripe returns all links.
        /// </summary>
        [JsonProperty("expired")]
        [STJS.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// Only return links for the given file.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }
    }
}
