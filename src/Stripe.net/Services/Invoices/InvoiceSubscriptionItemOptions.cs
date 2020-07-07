namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceSubscriptionItemOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Delete all usage for a given subscription item. Only allowed when <c>deleted</c> is set
        /// to true and the current plan's <c>usage_type</c> is metered.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// A flag that, if set to true, will delete the specified item.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Subscription item to update.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plan ID for this item, as a string.
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
        /// Boolean indicating whether the invoice returned would preview cancelling the
        /// subscription immediately.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A list of Tax Rate ids. These Tax Rates will override the default_tax_rates on the
        /// Subscription. When updating, pass an empty string to remove previously-defined tax
        /// rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
