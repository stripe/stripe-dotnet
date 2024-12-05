// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MarginListOptions : ListOptions
    {
        /// <summary>
        /// Only return margins that are active or inactive. For example, pass <c>true</c> to only
        /// list active margins.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}
