// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThresholdFilterCreditGrantsApplicabilityConfigOptions : INestedOptions
    {
        /// <summary>
        /// Specify the scope of this applicability config.
        /// </summary>
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif
        public AlertCreditBalanceThresholdFilterCreditGrantsApplicabilityConfigScopeOptions Scope { get; set; }
    }
}
