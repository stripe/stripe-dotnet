// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
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
