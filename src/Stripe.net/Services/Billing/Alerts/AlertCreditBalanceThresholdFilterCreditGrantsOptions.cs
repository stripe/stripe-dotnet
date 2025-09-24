// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThresholdFilterCreditGrantsOptions : INestedOptions
    {
        /// <summary>
        /// The applicability configuration for this credit grants filter.
        /// </summary>
        [JsonProperty("applicability_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applicability_config")]
#endif
        public AlertCreditBalanceThresholdFilterCreditGrantsApplicabilityConfigOptions ApplicabilityConfig { get; set; }
    }
}
