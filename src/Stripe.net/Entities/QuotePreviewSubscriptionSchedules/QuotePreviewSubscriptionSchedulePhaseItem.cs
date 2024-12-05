// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuotePreviewSubscriptionSchedulePhaseItem : StripeEntity<QuotePreviewSubscriptionSchedulePhaseItem>, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the related subscription
        /// advanced to a new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public QuotePreviewSubscriptionSchedulePhaseItemBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// The discounts applied to the subscription item. Subscription item discounts are applied
        /// before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuotePreviewSubscriptionSchedulePhaseItemDiscount> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an item. Metadata on this item will update the underlying subscription item's
        /// <c>metadata</c> when the phase is entered.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Plan

        /// <summary>
        /// (ID of the Plan)
        /// ID of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
        public string PlanId
        {
            get => this.InternalPlan?.Id;
            set => this.InternalPlan = SetExpandableFieldId(value, this.InternalPlan);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the plan to which the customer should be subscribed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Plan Plan
        {
            get => this.InternalPlan?.ExpandedObject;
            set => this.InternalPlan = SetExpandableFieldObject(value, this.InternalPlan);
        }

        [JsonProperty("plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
        internal ExpandableField<Plan> InternalPlan { get; set; }
        #endregion

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// ID of the price to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the price to which the customer should be subscribed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        /// <summary>
        /// Quantity of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this <c>phase_item</c>. When set, the
        /// <c>default_tax_rates</c> on the phase do not apply to this <c>phase_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// Options that configure the trial on the subscription item.
        /// </summary>
        [JsonProperty("trial")]
        public QuotePreviewSubscriptionSchedulePhaseItemTrial Trial { get; set; }
    }
}
