// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionItemUpdateOptions : BaseOptions, IHasMetadata
    {
        private SubscriptionItemBillingThresholdsOptions billingThresholds;
        private List<SubscriptionItemDiscountOptions> discounts;
        private Dictionary<string, string> metadata;
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
        /// The trial offer to apply to this subscription item.
        /// </summary>
        [JsonProperty("current_trial")]
        [STJS.JsonPropertyName("current_trial")]
        public SubscriptionItemCurrentTrialOptions CurrentTrial { get; set; }

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
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// Defaults to <c>false</c> (on-session).
        /// </summary>
        [JsonProperty("off_session")]
        [STJS.JsonPropertyName("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// Use <c>allow_incomplete</c> to transition the subscription to <c>status=past_due</c> if
        /// a payment is required but cannot be paid. This allows you to manage scenarios where
        /// additional user actions are needed to pay a subscription's invoice. For example, SCA
        /// regulation may require 3DS authentication to complete payment. See the <a
        /// href="https://docs.stripe.com/billing/migration/strong-customer-authentication">SCA
        /// Migration Guide</a> for Billing to learn more. This is the default behavior.
        ///
        /// Use <c>default_incomplete</c> to transition the subscription to <c>status=past_due</c>
        /// when payment is required and await explicit confirmation of the invoice's payment
        /// intent. This allows simpler management of scenarios where additional user actions are
        /// needed to pay a subscription’s invoice. Such as failed payments, <a
        /// href="https://docs.stripe.com/billing/migration/strong-customer-authentication">SCA
        /// regulation</a>, or collecting a mandate for a bank debit payment method.
        ///
        /// Use <c>pending_if_incomplete</c> to update the subscription using <a
        /// href="https://docs.stripe.com/billing/subscriptions/pending-updates">pending
        /// updates</a>. When you use <c>pending_if_incomplete</c> you can only pass the parameters
        /// <a
        /// href="https://docs.stripe.com/billing/pending-updates-reference#supported-attributes">supported
        /// by pending updates</a>.
        ///
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if a
        /// subscription's invoice cannot be paid. For example, if a payment method requires 3DS
        /// authentication due to SCA regulation and further user action is needed, this parameter
        /// does not update the subscription and returns an error instead. This was the default
        /// behavior for API versions prior to 2019-03-14. See the <a
        /// href="https://docs.stripe.com/changelog/2019-03-14">changelog</a> to learn more.
        /// One of: <c>allow_incomplete</c>, <c>default_incomplete</c>, <c>error_if_incomplete</c>,
        /// or <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        [STJS.JsonPropertyName("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// The identifier of the new plan for this subscription item.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>price</c> or <c>price_data</c> is required. When
        /// changing a subscription item's price, <c>quantity</c> is set to 1 unless a
        /// <c>quantity</c> parameter is provided.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
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
