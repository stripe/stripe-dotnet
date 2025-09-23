// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionApplyInvoiceDiscountRulePercentOffOptions : INestedOptions
    {
        /// <summary>
        /// The maximum number of times this discount can be applied for this cadence.
        /// </summary>
        [JsonProperty("maximum_applications")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_applications")]
#endif
        public IntentCreateActionApplyInvoiceDiscountRulePercentOffMaximumApplicationsOptions MaximumApplications { get; set; }

        /// <summary>
        /// Percent that will be taken off of the amount. For example, percent_off of 50.0 will make
        /// $100 amount $50 instead.
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public decimal? PercentOff { get; set; }
    }
}
