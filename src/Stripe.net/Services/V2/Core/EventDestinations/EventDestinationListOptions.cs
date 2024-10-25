// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventDestinationListOptions : ListOptions
    {
        /// <summary>
        /// Additional fields to include in the response. Currently supports
        /// <c>webhook_endpoint.url</c>.
        /// </summary>
        [JsonProperty("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// The requested page.
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }
    }
}
