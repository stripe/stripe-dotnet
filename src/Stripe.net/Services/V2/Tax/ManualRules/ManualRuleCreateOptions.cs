// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ManualRuleCreateOptions : BaseOptions
    {
        /// <summary>
        /// Location where the rule applies.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public ManualRuleCreateLocationOptions Location { get; set; }

        /// <summary>
        /// Products associated with the rule.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<ManualRuleCreateProductOptions> Products { get; set; }

        /// <summary>
        /// Tax rates to be applied.
        /// </summary>
        [JsonProperty("scheduled_tax_rates")]
        [STJS.JsonPropertyName("scheduled_tax_rates")]
        public List<ManualRuleCreateScheduledTaxRateOptions> ScheduledTaxRates { get; set; }
    }
}
