namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. When updating, pass an empty string to remove previously-defined
        /// thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// Use <c>allow_incomplete</c> to transition the subscription to <c>status=past_due</c> if
        /// a payment is required but cannot be paid. This allows you to manage scenarios where
        /// additional user actions are needed to pay a subscription's invoice. For example, SCA
        /// regulation may require 3DS authentication to complete payment. See the <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication">SCA
        /// Migration Guide</a> for Billing to learn more. This is the default behavior.
        ///
        /// Use <c>pending_if_incomplete</c> to update the subscription using <a
        /// href="https://stripe.com/docs/billing/subscriptions/pending-updates">pending
        /// updates</a>. When you use <c>pending_if_incomplete</c> you can only pass the parameters
        /// <a
        /// href="https://stripe.com/docs/billing/pending-updates-reference#supported-attributes">supported
        /// by pending updates</a>.
        ///
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if a
        /// subscription's invoice cannot be paid. For example, if a payment method requires 3DS
        /// authentication due to SCA regulation and further user action is needed, this parameter
        /// does not update the subscription and returns an error instead. This was the default
        /// behavior for API versions prior to 2019-03-14. See the <a
        /// href="https://stripe.com/docs/upgrades#2019-03-14">changelog</a> to learn more.
        /// One of: <c>allow_incomplete</c>, <c>error_if_incomplete</c>, or
        /// <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// The identifier of the new plan for this subscription item.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// This field has been renamed to <c>proration_behavior</c>. <c>prorate=true</c> can be
        /// replaced with <c>proration_behavior=create_prorations</c> and <c>prorate=false</c> can
        /// be replaced with <c>proration_behavior=none</c>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. Valid values are <c>create_prorations</c>, <c>none</c>, or
        /// <c>always_invoice</c>.
        ///
        /// Passing <c>create_prorations</c> will cause proration invoice items to be created when
        /// applicable. These proration items will only be invoiced immediately under <a
        /// href="https://stripe.com/docs/subscriptions/upgrading-downgrading#immediate-payment">certain
        /// conditions</a>. In order to always invoice immediately for prorations, pass
        /// <c>always_invoice</c>.
        ///
        /// Prorations can be disabled by passing <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the <a
        /// href="https://stripe.com/docs/api#retrieve_customer_invoice">upcoming invoice</a>
        /// endpoint.
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
        /// A list of <a href="https://stripe.com/docs/api/tax_rates">Tax Rate</a> ids. These Tax
        /// Rates will override the <a
        /// href="https://stripe.com/docs/api/subscriptions/create#create_subscription-default_tax_rates"><c>default_tax_rates</c></a>
        /// on the Subscription. When updating, pass an empty string to remove previously-defined
        /// tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
