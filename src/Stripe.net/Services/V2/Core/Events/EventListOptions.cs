// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;

    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }
    }
}
