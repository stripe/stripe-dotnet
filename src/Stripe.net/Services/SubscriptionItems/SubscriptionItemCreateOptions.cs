// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionItemCreateOptions : BaseOptions, IHasMetadata
    {
        private SubscriptionItemBillingThresholdsOptions billingThresholds;
        private List<SubscriptionItemDiscountOptions> discounts;
        private List<string> taxRates;

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("billing_thresholds")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds
        {
            get => this.billingThresholds;
            set
            {
                this.billingThresholds = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The coupons to redeem into discounts for the subscription item.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("discounts")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<SubscriptionItemDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

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
        /// The identifier of the plan to add to the subscription.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

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

        /// <summary>
        /// The quantity you'd like to apply to the subscription item you're creating.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The identifier of the subscription to modify.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// A list of <a href="https://docs.stripe.com/api/tax_rates">Tax Rate</a> ids. These Tax
        /// Rates will override the <a
        /// href="https://docs.stripe.com/api/subscriptions/create#create_subscription-default_tax_rates"><c>default_tax_rates</c></a>
        /// on the Subscription. When updating, pass an empty string to remove previously-defined
        /// tax rates.
        /// </summary>
        [JsonProperty("tax_rates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_rates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> TaxRates
        {
            get => this.taxRates;
            set
            {
                this.taxRates = value;
                this.SetTracker.Track();
            }
        }
    }
}
