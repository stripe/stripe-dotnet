using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripePlan : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        #region Expandable Product
        /// <summary>
        /// ID of the product linked to this plan
        /// <para>You can expand the Product by setting the ExpandProduct property on the service to true</para>
        /// </summary>
        public string ProductId { get; set; }

        [JsonIgnore]
        public StripeProduct Product { get; set; }

        [JsonProperty("product")]
        internal object InternalProduct
        {
            set
            {
                StringOrObject<StripeProduct>.Map(value, s => ProductId = s, o => Product = o);
            }
        }
        #endregion

        [JsonProperty("tiers")]
        public List<StripePlanTier> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transform_usage")]
        public StripePlanTransformUsage TransformUsage { get; set; }

        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
