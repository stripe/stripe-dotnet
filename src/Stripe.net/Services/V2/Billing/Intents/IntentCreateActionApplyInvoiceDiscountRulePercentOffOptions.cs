// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplyInvoiceDiscountRulePercentOffOptions : INestedOptions
    {
        /// <summary>
        /// The maximum number of times this discount can be applied for this cadence.
        /// </summary>
        [JsonProperty("maximum_applications")]
        [STJS.JsonPropertyName("maximum_applications")]
        public IntentCreateActionApplyInvoiceDiscountRulePercentOffMaximumApplicationsOptions MaximumApplications { get; set; }

        /// <summary>
        /// Percent that will be taken off of the amount. For example, percent_off of 50.0 will make
        /// $100 amount $50 instead.
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public string PercentOff { get; set; }
    }
}
