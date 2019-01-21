namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Plan : StripeEntity<Plan>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long IntervalCount { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        #region Expandable Product

        /// <summary>
        /// ID of the product linked to this plan
        /// <para>You can expand the Product by setting the ExpandProduct property on the service to true</para>
        /// </summary>
        [JsonIgnore]
        public string ProductId => this.InternalProduct.Id;

        [JsonIgnore]
        public Product Product => this.InternalProduct.ExpandedObject;

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        [JsonProperty("tiers")]
        public List<PlanTier> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transform_usage")]
        public PlanTransformUsage TransformUsage { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
