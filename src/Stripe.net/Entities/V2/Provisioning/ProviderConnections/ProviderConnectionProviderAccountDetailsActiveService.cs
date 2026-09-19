// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderConnectionProviderAccountDetailsActiveService : StripeEntity<ProviderConnectionProviderAccountDetailsActiveService>
    {
        /// <summary>
        /// Display name of the service.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Identifier of the resource at the provider that backs this service, if any.
        /// </summary>
        [JsonProperty("provider_resource_id")]
        [STJS.JsonPropertyName("provider_resource_id")]
        public string ProviderResourceId { get; set; }

        /// <summary>
        /// Identifier of the service at the provider.
        /// </summary>
        [JsonProperty("service_id")]
        [STJS.JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// Current status of the service.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
