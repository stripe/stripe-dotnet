// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationDeveloperCapabilities : StripeEntity<AccountConfigurationDeveloperCapabilities>
    {
        /// <summary>
        /// Enables the Account to use Stripe developer tooling.
        /// </summary>
        [JsonProperty("projects")]
        [STJS.JsonPropertyName("projects")]
        public AccountConfigurationDeveloperCapabilitiesProjects Projects { get; set; }
    }
}
