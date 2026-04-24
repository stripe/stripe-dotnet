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
        /// Percent that is taken off the amount. For example, a percent_off of 50.0 reduces a 100
        /// USD amount to 50 USD.
        /// </summary>
        [JsonProperty("percent_off")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("percent_off")]
        public decimal? PercentOff { get; set; }
    }
}
