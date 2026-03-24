// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Set of filters to query events within a range of <c>created</c> timestamps.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public EventListCreatedOptions Created { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
        [STJS.JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// An array of up to 20 strings containing specific event names.
        /// </summary>
        [JsonProperty("types")]
        [STJS.JsonPropertyName("types")]
        public List<string> Types { get; set; }
    }
}
