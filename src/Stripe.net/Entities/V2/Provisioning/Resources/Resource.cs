// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>Resource</c> resource represents a provider-managed resource provisioned on
    /// behalf of a <c>Project</c>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Resource : StripeEntity<Resource>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the resource.
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
        /// Catalog partition containing the resource's provider service.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// Time at which the resource was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Provider environment in which the resource runs.
        /// One of: <c>dev</c>, or <c>prod</c>.
        /// </summary>
        [JsonProperty("environment")]
        [STJS.JsonPropertyName("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Error reported when provisioning the resource fails.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Whether this resource uses Stripe live-mode objects. This is independent of the provider
        /// catalog and is immutable for the lifetime of the resource.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Human-readable name of the resource.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Schema describing additional information the provider requires to finish provisioning.
        /// </summary>
        [JsonProperty("needs_information_schema")]
        [STJS.JsonPropertyName("needs_information_schema")]
        public Dictionary<string, object> NeedsInformationSchema { get; set; }

        /// <summary>
        /// Identifier of the provider that manages the resource.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Identifier of the provider service used to provision the resource.
        /// </summary>
        [JsonProperty("service_ref")]
        [STJS.JsonPropertyName("service_ref")]
        public string ServiceRef { get; set; }

        /// <summary>
        /// Current provisioning status of the resource.
        /// One of: <c>complete</c>, <c>errored</c>, <c>needs_information</c>, <c>pending</c>, or
        /// <c>removed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Message supplied by the provider when the resource becomes ready.
        /// </summary>
        [JsonProperty("user_message")]
        [STJS.JsonPropertyName("user_message")]
        public ResourceUserMessage UserMessage { get; set; }
    }
}
