// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleAmendmentItemActionAddOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The discounts applied to the item. Subscription item discounts are applied before
        /// subscription discounts.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SubscriptionScheduleAmendmentItemActionAddDiscountOptions> Discounts { get; set; }

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
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates that apply to this subscription item. When set, the
        /// <c>default_tax_rates</c> on the subscription do not apply to this
        /// <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// Options that configure the trial on the subscription item.
        /// </summary>
        [JsonProperty("trial")]
        [STJS.JsonPropertyName("trial")]
        public SubscriptionScheduleAmendmentItemActionAddTrialOptions Trial { get; set; }

        /// <summary>
        /// The ID of the trial offer to apply to the configuration item.
        /// </summary>
        [JsonProperty("trial_offer")]
        [STJS.JsonPropertyName("trial_offer")]
        public string TrialOffer { get; set; }
    }
}
