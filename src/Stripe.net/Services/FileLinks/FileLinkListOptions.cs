// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Filter links by their expiration status. By default, Stripe returns all links.
        /// </summary>
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// Only return links for the given file.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }
    }
}
