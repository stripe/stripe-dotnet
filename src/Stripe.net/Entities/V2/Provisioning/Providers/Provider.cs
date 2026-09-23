// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>Provider</c> resource represents a third-party provider available in the
    /// provisioning catalog.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Provider : StripeEntity<Provider>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the provider.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Capabilities supported by the provider.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// Categories the provider belongs to.
        /// </summary>
        [JsonProperty("categories")]
        [STJS.JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Schema describing the configuration accepted by this provider.
        /// </summary>
        [JsonProperty("configuration_schema")]
        [STJS.JsonPropertyName("configuration_schema")]
        public Dictionary<string, object> ConfigurationSchema { get; set; }

        /// <summary>
        /// Time at which the provider was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Deep-link purposes supported by the provider.
        /// </summary>
        [JsonProperty("deep_link_purposes")]
        [STJS.JsonPropertyName("deep_link_purposes")]
        public List<string> DeepLinkPurposes { get; set; }

        /// <summary>
        /// Description of the provider.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// proto3 scalar defaults apply: if unset, this value is <c>false</c>.
        /// </summary>
        [JsonProperty("development")]
        [STJS.JsonPropertyName("development")]
        public bool Development { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// URL of additional context about the provider intended for LLM consumption.
        /// </summary>
        [JsonProperty("llm_context")]
        [STJS.JsonPropertyName("llm_context")]
        public string LlmContext { get; set; }

        /// <summary>
        /// Human-readable name of the provider.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// URL of the provider's privacy policy.
        /// </summary>
        [JsonProperty("privacy_policy_url")]
        [STJS.JsonPropertyName("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// URL of the provider's terms of service.
        /// </summary>
        [JsonProperty("tos_url")]
        [STJS.JsonPropertyName("tos_url")]
        public string TosUrl { get; set; }

        /// <summary>
        /// URL of the provider's website.
        /// </summary>
        [JsonProperty("website_url")]
        [STJS.JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; }
    }
}
