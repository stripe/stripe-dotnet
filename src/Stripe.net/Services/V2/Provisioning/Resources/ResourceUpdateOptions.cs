// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ResourceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Catalog partition of the resource.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// New provider-specific configuration payload for the resource.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// Provider's service id to switch the resource to. If omitted, the resource's existing
        /// service is retained and this is treated as a config-only update.
        /// </summary>
        [JsonProperty("service_ref")]
        [STJS.JsonPropertyName("service_ref")]
        public string ServiceRef { get; set; }
    }
}
