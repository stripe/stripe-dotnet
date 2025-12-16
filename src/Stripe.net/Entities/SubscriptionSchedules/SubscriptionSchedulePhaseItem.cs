// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SubscriptionSchedulePhaseItem : StripeEntity<SubscriptionSchedulePhaseItem>, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the related subscription
        /// advanced to a new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_thresholds")]
#endif
        public SubscriptionSchedulePhaseItemBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// The discounts applied to the subscription item. Subscription item discounts are applied
        /// before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<SubscriptionSchedulePhaseItemDiscount> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an item. Metadata on this item will update the underlying subscription item's
        /// <c>metadata</c> when the phase is entered.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Plan

        /// <summary>
        /// (ID of the Plan)
        /// ID of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Plan Plan
        {
            get => this.InternalPlan?.ExpandedObject;
            set => this.InternalPlan = SetExpandableFieldObject(value, this.InternalPlan);
        }

        [JsonProperty("plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Plan>))]
#endif
        internal ExpandableField<Plan> InternalPlan { get; set; }
        #endregion

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// ID of the price to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
#endif
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        /// <summary>
        /// Quantity of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this <c>phase_item</c>. When set, the
        /// <c>default_tax_rates</c> on the phase do not apply to this <c>phase_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<TaxRate> TaxRates { get; set; }
    }
}
