// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionApplyInvoiceDiscountRuleOptions : INestedOptions
    {
        /// <summary>
        /// The entity that the discount rule applies to, for example, the cadence.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public string AppliesTo { get; set; }

        /// <summary>
        /// Type of the discount rule.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Configuration for percentage off discount.
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public IntentCreateActionApplyInvoiceDiscountRulePercentOffOptions PercentOff { get; set; }
    }
}
