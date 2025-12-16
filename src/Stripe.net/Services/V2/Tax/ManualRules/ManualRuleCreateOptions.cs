// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ManualRuleCreateOptions : BaseOptions
    {
        /// <summary>
        /// Location where the rule applies.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public ManualRuleCreateLocationOptions Location { get; set; }

        /// <summary>
        /// Products associated with the rule.
        /// </summary>
        [JsonProperty("products")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("products")]
#endif
        public List<ManualRuleCreateProductOptions> Products { get; set; }

        /// <summary>
        /// Tax rates to be applied.
        /// </summary>
        [JsonProperty("scheduled_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scheduled_tax_rates")]
#endif
        public List<ManualRuleCreateScheduledTaxRateOptions> ScheduledTaxRates { get; set; }
    }
}
