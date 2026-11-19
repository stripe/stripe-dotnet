// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentBillingGroupData : StripeEntity<IntentBillingGroupData>
    {
        /// <summary>
        /// Billing setting overrides for the group. If omitted, the applicable defaults are used.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public IntentBillingGroupDataBillingSettings BillingSettings { get; set; }

        /// <summary>
        /// The ID of the Customer object whose invoices are grouped.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the PaymentMethod object used by default. If unset, the customer's default
        /// payment method is used.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// The strategy used to group member invoices.
        /// </summary>
        [JsonProperty("grouping_behavior")]
        [STJS.JsonPropertyName("grouping_behavior")]
        public IntentBillingGroupDataGroupingBehavior GroupingBehavior { get; set; }

        /// <summary>
        /// An internal key you can use to find a particular billing group. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }
    }
}
