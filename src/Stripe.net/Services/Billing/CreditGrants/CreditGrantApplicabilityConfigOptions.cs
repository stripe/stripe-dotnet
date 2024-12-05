// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigOptions : INestedOptions
    {
        /// <summary>
        /// Specify the scope of this applicability config.
        /// </summary>
        [JsonProperty("scope")]
        public CreditGrantApplicabilityConfigScopeOptions Scope { get; set; }
    }
}
