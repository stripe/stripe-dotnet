// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProjectCreateOptions : BaseOptions
    {
        /// <summary>
        /// Catalog partition to create the project in.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// Human-readable name for the new project.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of the developer profile to associate with the new project.
        /// </summary>
        [JsonProperty("project_profile")]
        [STJS.JsonPropertyName("project_profile")]
        public string ProjectProfile { get; set; }
    }
}
