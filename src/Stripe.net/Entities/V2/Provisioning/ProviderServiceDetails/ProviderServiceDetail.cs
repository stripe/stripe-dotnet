// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>ProviderServiceDetail</c> resource represents a service offered by a provider in
    /// the catalog.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetail : StripeEntity<ProviderServiceDetail>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the provider service.
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
        /// Updates allowed for resources using this service.
        /// </summary>
        [JsonProperty("allowed_updates")]
        [STJS.JsonPropertyName("allowed_updates")]
        public List<ProviderServiceDetailAllowedUpdate> AllowedUpdates { get; set; }

        /// <summary>
        /// Availability of the service.
        /// One of: <c>available</c>, <c>not_in_country</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("availability")]
        [STJS.JsonPropertyName("availability")]
        public string Availability { get; set; }

        /// <summary>
        /// Categories the service belongs to.
        /// </summary>
        [JsonProperty("categories")]
        [STJS.JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Schema describing the configuration accepted by this service.
        /// </summary>
        [JsonProperty("configuration_schema")]
        [STJS.JsonPropertyName("configuration_schema")]
        public Dictionary<string, object> ConfigurationSchema { get; set; }

        /// <summary>
        /// Constraints on resources using this service.
        /// </summary>
        [JsonProperty("constraints")]
        [STJS.JsonPropertyName("constraints")]
        public List<ProviderServiceDetailConstraint> Constraints { get; set; }

        /// <summary>
        /// Time at which the service was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Description of the service.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Denormalized from the parent Provider. If a Provider's partition changes, re-sync its
        /// services. proto3 scalar defaults apply: if unset, this value is <c>false</c>.
        /// </summary>
        [JsonProperty("development")]
        [STJS.JsonPropertyName("development")]
        public bool Development { get; set; }

        /// <summary>
        /// Group the service belongs to, used to organize related services.
        /// </summary>
        [JsonProperty("group")]
        [STJS.JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// Kind of the service.
        /// One of: <c>deployable</c>, or <c>plan</c>.
        /// </summary>
        [JsonProperty("kind")]
        [STJS.JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// URL of additional context about the service intended for LLM consumption.
        /// </summary>
        [JsonProperty("llm_context")]
        [STJS.JsonPropertyName("llm_context")]
        public string LlmContext { get; set; }

        /// <summary>
        /// Pricing details for the service.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ProviderServiceDetailPricing Pricing { get; set; }

        /// <summary>
        /// Identifier of the provider that offers this service.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Human-readable name of the provider that offers this service.
        /// </summary>
        [JsonProperty("provider_name")]
        [STJS.JsonPropertyName("provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// Scope of the service.
        /// One of: <c>account</c>, or <c>project</c>.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Identifier of the service, unique within its provider.
        /// </summary>
        [JsonProperty("service_id")]
        [STJS.JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// Deprecated: use allowed_updates instead.
        /// </summary>
        [JsonProperty("updateable_to")]
        [STJS.JsonPropertyName("updateable_to")]
        public List<string> UpdateableTo { get; set; }
    }
}
