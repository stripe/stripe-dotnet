// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationDeveloperCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Updates access to Stripe developer tooling.
        /// </summary>
        [JsonProperty("projects")]
        [STJS.JsonPropertyName("projects")]
        public AccountUpdateConfigurationDeveloperCapabilitiesProjectsOptions Projects { get; set; }
    }
}
