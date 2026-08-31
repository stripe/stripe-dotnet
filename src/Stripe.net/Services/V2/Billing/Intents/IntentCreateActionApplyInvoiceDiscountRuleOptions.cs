// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplyInvoiceDiscountRuleOptions : INestedOptions
    {
        /// <summary>
        /// The entity that the discount rule applies to, for example, the cadence.
        /// One of: <c>cadence</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public string AppliesTo { get; set; }

        /// <summary>
        /// Configuration for percentage off discount.
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public IntentCreateActionApplyInvoiceDiscountRulePercentOffOptions PercentOff { get; set; }

        /// <summary>
        /// Type of the discount rule.
        /// One of: <c>percent_off</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
