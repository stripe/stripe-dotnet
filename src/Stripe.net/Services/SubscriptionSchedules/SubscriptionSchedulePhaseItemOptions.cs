// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. When updating, pass an empty string to remove previously-defined
        /// thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionSchedulePhaseItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to a configuration item. Metadata on a configuration item will update the
        /// underlying subscription item's <c>metadata</c> when the phase is entered, adding new
        /// keys and replacing existing keys. Individual keys in the subscription item's
        /// <c>metadata</c> can be unset by posting an empty value to them in the configuration
        /// item's <c>metadata</c>. To unset all keys in the subscription item's <c>metadata</c>,
        /// update the subscription item directly or unset every key individually from the
        /// configuration item's <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The plan ID to subscribe to. You may specify the same ID in <c>plan</c> and
        /// <c>price</c>.
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
        public SubscriptionSchedulePhaseItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for the given price. Can be set only if the price's <c>usage_type</c> is
        /// <c>licensed</c> and not <c>metered</c>.
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
