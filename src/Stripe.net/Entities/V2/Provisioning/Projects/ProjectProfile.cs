// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProjectProfile : StripeEntity<ProjectProfile>
    {
        /// <summary>
        /// Email address associated with the developer profile.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Fields of the developer profile that have been verified.
        /// One of: <c>country</c>, <c>email</c>, <c>name</c>, or <c>phone</c>.
        /// </summary>
        [JsonProperty("verified_fields")]
        [STJS.JsonPropertyName("verified_fields")]
        public List<string> VerifiedFields { get; set; }
    }
}
