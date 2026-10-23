// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ResourceConfiguration : StripeEntity<ResourceConfiguration>
    {
        /// <summary>
        /// Exact top-level configuration key names, unique and sorted in ascending lexicographic
        /// order. This array is present and empty when the available configuration has no entries.
        /// </summary>
        [JsonProperty("key_names")]
        [STJS.JsonPropertyName("key_names")]
        public List<string> KeyNames { get; set; }
    }
}
