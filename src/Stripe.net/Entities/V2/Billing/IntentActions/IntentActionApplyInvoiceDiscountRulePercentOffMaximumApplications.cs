// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplyInvoiceDiscountRulePercentOffMaximumApplications : StripeEntity<IntentActionApplyInvoiceDiscountRulePercentOffMaximumApplications>
    {
        /// <summary>
        /// The type of maximum applications configuration.
        /// One of: <c>indefinite</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
