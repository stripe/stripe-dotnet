namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseItem : StripeEntity<SubscriptionSchedulePhaseItem>
    {
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholds BillingThresholds { get; set; }

        #region Expandable Plan

        [JsonIgnore]
        public string PlanId
        {
            get => this.InternalPlan?.Id;
            set => this.InternalPlan = SetExpandableFieldId(value, this.InternalPlan);
        }

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

        [JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

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

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
