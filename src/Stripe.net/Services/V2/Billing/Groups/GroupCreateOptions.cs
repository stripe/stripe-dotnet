// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Billing setting overrides for the group. If omitted, the applicable defaults are used.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public GroupCreateBillingSettingsOptions BillingSettings { get; set; }

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
        public GroupCreateGroupingBehaviorOptions GroupingBehavior { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, or <c>invoice_discount_rules</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// An internal key you can use to find a particular billing group. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object for storing additional
        /// structured information.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
