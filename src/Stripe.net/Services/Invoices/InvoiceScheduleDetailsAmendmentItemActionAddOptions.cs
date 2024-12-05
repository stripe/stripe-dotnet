// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsAmendmentItemActionAddOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The discounts applied to the item. Subscription item discounts are applied before
        /// subscription discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceScheduleDetailsAmendmentItemActionAddDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates that apply to this subscription item. When set, the
        /// <c>default_tax_rates</c> on the subscription do not apply to this
        /// <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// Options that configure the trial on the subscription item.
        /// </summary>
        [JsonProperty("trial")]
        public InvoiceScheduleDetailsAmendmentItemActionAddTrialOptions Trial { get; set; }
    }
}
