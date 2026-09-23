// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationDeveloperCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Requests access to Stripe developer tooling.
        /// </summary>
        [JsonProperty("projects")]
        [STJS.JsonPropertyName("projects")]
        public AccountCreateConfigurationDeveloperCapabilitiesProjectsOptions Projects { get; set; }
    }
}
