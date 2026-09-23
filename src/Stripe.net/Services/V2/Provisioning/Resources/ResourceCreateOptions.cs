// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ResourceCreateOptions : BaseOptions
    {
        /// <summary>
        /// Catalog partition to create the resource in.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// Provider-specific configuration payload for the resource.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// Environment the resource should be created in.
        /// One of: <c>dev</c>, or <c>prod</c>.
        /// </summary>
        [JsonProperty("environment")]
        [STJS.JsonPropertyName("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Whether the resource should use Stripe live-mode objects. When omitted, this resolves to
        /// true.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Human-readable name for the resource.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of the project to create the resource in.
        /// </summary>
        [JsonProperty("project")]
        [STJS.JsonPropertyName("project")]
        public string Project { get; set; }

        /// <summary>
        /// Identifier of the provider to create the resource with.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Identifier of the provider service to create the resource from.
        /// </summary>
        [JsonProperty("service_ref")]
        [STJS.JsonPropertyName("service_ref")]
        public string ServiceRef { get; set; }
    }
}
