// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionItemDeleteOptions : BaseOptions
    {
        /// <summary>
        /// Delete all usage for the given subscription item. Allowed only when the current plan's
        /// <c>usage_type</c> is <c>metered</c>.
        /// </summary>
        [JsonProperty("clear_usage")]
        [STJS.JsonPropertyName("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// Controls how Stripe handles payment when a subscription update requires payment and
        /// <c>collection_method=charge_automatically</c>.
        /// One of: <c>allow_incomplete</c>, <c>default_incomplete</c>, <c>error_if_incomplete</c>,
        /// or <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        [STJS.JsonPropertyName("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the <a
        /// href="https://stripe.com/api/invoices/create_preview">upcoming invoice</a> endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
