// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A ManualRule holds tax rates for a BillableItem. It can hold at most 5 distinct tax
    /// rates.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ManualRule : StripeEntity<ManualRule>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the ManualRule object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The time at which the ManualRule object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Location where the rule applies.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public ManualRuleLocation Location { get; set; }

        /// <summary>
        /// Products associated with the rule.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<ManualRuleProduct> Products { get; set; }

        /// <summary>
        /// Tax rates to be applied.
        /// </summary>
        [JsonProperty("scheduled_tax_rates")]
        [STJS.JsonPropertyName("scheduled_tax_rates")]
        public List<ManualRuleScheduledTaxRate> ScheduledTaxRates { get; set; }

        /// <summary>
        /// The status of the ManualRule object.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
