// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditGrantApplicabilityConfigOptions : INestedOptions
    {
        /// <summary>
        /// Specify the scope of this applicability config.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public CreditGrantApplicabilityConfigScopeOptions Scope { get; set; }
    }
}
