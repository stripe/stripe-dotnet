namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public abstract class SubscriptionItemSharedOptions : BaseOptions
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if
        /// the invoice caused by the item creation  cannot be paid. Otherwise use
        /// <c>allow_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// REQUIRED: The identifier of the plan to add to the subscription.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Flag indicating whether to prorate switching plans during a billing cycle.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the
        /// upcoming invoice endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// The quantity you’d like to apply to the subscription item you’re creating.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this subscription item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
