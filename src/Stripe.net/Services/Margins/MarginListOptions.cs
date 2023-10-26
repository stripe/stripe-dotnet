// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MarginListOptions : ListOptions
    {
        /// <summary>
        /// Only return margins that are active or inactive, i.e., pass false to list all inactive
        /// margins.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}
