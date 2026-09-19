// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>Project</c> resource represents a container for provisioned resources and their
    /// associated configuration.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Project : StripeEntity<Project>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the project.
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
        /// Catalog partition the project belongs to.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// Time at which the project was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Human-readable name of the project.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Use the /v2/provisioning/identity endpoint instead for IAM information.
        /// </summary>
        [JsonProperty("profile")]
        [STJS.JsonPropertyName("profile")]
        public ProjectProfile Profile { get; set; }

        /// <summary>
        /// Identifier of the developer profile associated with the project.
        /// </summary>
        [JsonProperty("project_profile")]
        [STJS.JsonPropertyName("project_profile")]
        public string ProjectProfile { get; set; }
    }
}
