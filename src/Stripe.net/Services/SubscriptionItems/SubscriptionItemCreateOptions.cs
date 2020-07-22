namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can
        /// be useful for storing additional information about the object in a
        /// structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if
        /// the invoice caused by the item creation  cannot be paid. Otherwise use
        /// <c>allow_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// The ID of the plan to add to the subscription.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new price object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Flag indicating whether to prorate switching plans during a billing cycle.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// Determines how to handle
        /// <a href="https://stripe.com/docs/billing/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the billing cycle changes. The value defaults to
        /// <c>create_prorations</c>, indicating that proration invoice items should
        /// be created. Prorations can be disabled by setting the value to
        /// <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the
        /// upcoming invoice endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// The quantity you'd like to apply to the subscription item you're creating.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// REQUIRED: The identifier of the subscription to modify.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this subscription item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
