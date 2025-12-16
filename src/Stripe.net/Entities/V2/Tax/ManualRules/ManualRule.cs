// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A ManualRule holds tax rates for a BillableItem. It can hold at most 5 distinct tax
    /// rates.
    /// </summary>
    public class ManualRule : StripeEntity<ManualRule>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the ManualRule object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The time at which the ManualRule object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Location where the rule applies.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public ManualRuleLocation Location { get; set; }

        /// <summary>
        /// Products associated with the rule.
        /// </summary>
        [JsonProperty("products")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("products")]
#endif
        public List<ManualRuleProduct> Products { get; set; }

        /// <summary>
        /// Tax rates to be applied.
        /// </summary>
        [JsonProperty("scheduled_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scheduled_tax_rates")]
#endif
        public List<ManualRuleScheduledTaxRate> ScheduledTaxRates { get; set; }

        /// <summary>
        /// The status of the ManualRule object.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
