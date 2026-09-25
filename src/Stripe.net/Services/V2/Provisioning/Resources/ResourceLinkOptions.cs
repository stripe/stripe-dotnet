// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ResourceLinkOptions : BaseOptions
    {
        /// <summary>
        /// Catalog partition of the existing resource.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// Environment the existing resource runs in.
        /// One of: <c>dev</c>, or <c>prod</c>.
        /// </summary>
        [JsonProperty("environment")]
        [STJS.JsonPropertyName("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Whether the resource should use Stripe live-mode objects. When omitted, this resolves to
        /// false for a sandbox target and true otherwise. Sandbox targets cannot link live-mode
        /// resources.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Identifier of the project to link the resource to.
        /// </summary>
        [JsonProperty("project")]
        [STJS.JsonPropertyName("project")]
        public string Project { get; set; }

        /// <summary>
        /// Identifier of the provider that hosts the existing resource.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Identifier of the provider service the existing resource belongs to.
        /// </summary>
        [JsonProperty("service_ref")]
        [STJS.JsonPropertyName("service_ref")]
        public string ServiceRef { get; set; }
    }
}
