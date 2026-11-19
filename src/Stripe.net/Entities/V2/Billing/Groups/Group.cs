// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Billing Group combines member invoices into a consolidated invoice according to shared
    /// grouping behavior.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Group : StripeEntity<Group>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The ID of the BillingGroup object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The effective billing settings for the group. Returned only when <c>billing_settings</c>
        /// is included in the request.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public GroupBillingSettings BillingSettings { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        public GroupGroupingBehavior GroupingBehavior { get; set; }

        /// <summary>
        /// The discount rules applied to all invoices for the group's underlying cadence. Returned
        /// only when <c>invoice_discount_rules</c> is included in the request.
        /// </summary>
        [JsonProperty("invoice_discount_rules")]
        [STJS.JsonPropertyName("invoice_discount_rules")]
        public List<GroupInvoiceDiscountRule> InvoiceDiscountRules { get; set; }

        /// <summary>
        /// Whether the billing group exists in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

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

        /// <summary>
        /// The date when the billing group will next create a consolidated invoice.
        /// </summary>
        [JsonProperty("next_billing_date")]
        [STJS.JsonPropertyName("next_billing_date")]
        public DateTime NextBillingDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The current status of the billing group.
        /// One of: <c>active</c>, or <c>canceled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for the billing group's status transitions.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public GroupStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The ID of the TestClock object associated with the billing group.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
