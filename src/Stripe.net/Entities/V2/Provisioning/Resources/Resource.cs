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
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// One of: <c>dev</c>, or <c>prod</c>.
        /// </summary>
        [JsonProperty("environment")]
        [STJS.JsonPropertyName("environment")]
        public string Environment { get; set; }

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

        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("needs_information_schema")]
        [STJS.JsonPropertyName("needs_information_schema")]
        public Dictionary<string, object> NeedsInformationSchema { get; set; }

        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        [JsonProperty("service_ref")]
        [STJS.JsonPropertyName("service_ref")]
        public string ServiceRef { get; set; }

        /// <summary>
        /// One of: <c>complete</c>, <c>errored</c>, <c>needs_information</c>, <c>pending</c>, or
        /// <c>removed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("user_message")]
        [STJS.JsonPropertyName("user_message")]
        public ResourceUserMessage UserMessage { get; set; }
    }
}
