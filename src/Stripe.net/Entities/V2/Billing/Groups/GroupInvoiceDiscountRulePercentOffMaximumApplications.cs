// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GroupInvoiceDiscountRulePercentOffMaximumApplications : StripeEntity<GroupInvoiceDiscountRulePercentOffMaximumApplications>
    {
        /// <summary>
        /// The number of times this discount can be applied when the type is <c>times</c>.
        /// </summary>
        [JsonProperty("times")]
        [STJS.JsonPropertyName("times")]
        public long? Times { get; set; }

        /// <summary>
        /// Max applications type of this discount, ex: indefinite.
        /// One of: <c>indefinite</c>, or <c>times</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
