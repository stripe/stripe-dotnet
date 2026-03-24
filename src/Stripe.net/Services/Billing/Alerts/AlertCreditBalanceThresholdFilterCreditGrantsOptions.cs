// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreditBalanceThresholdFilterCreditGrantsOptions : INestedOptions
    {
        /// <summary>
        /// The applicability configuration for this credit grants filter.
        /// </summary>
        [JsonProperty("applicability_config")]
        [STJS.JsonPropertyName("applicability_config")]
        public AlertCreditBalanceThresholdFilterCreditGrantsApplicabilityConfigOptions ApplicabilityConfig { get; set; }
    }
}
