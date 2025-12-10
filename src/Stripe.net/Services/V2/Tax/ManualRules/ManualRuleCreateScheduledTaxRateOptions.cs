// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ManualRuleCreateScheduledTaxRateOptions : INestedOptions
    {
        /// <summary>
        /// The tax rates to be applied.
        /// </summary>
        [JsonProperty("rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rates")]
#endif
        public List<ManualRuleCreateScheduledTaxRateRateOptions> Rates { get; set; }

        /// <summary>
        /// The start time for the tax rate.
        /// </summary>
        [JsonProperty("starts_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
#endif
        public DateTime? StartsAt { get; set; }
    }
}
