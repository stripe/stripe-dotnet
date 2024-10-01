// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;

    public class EventListOptions : ListOptions
    {
        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// The requested page number.
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }
    }
}
