// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ManualRuleUpdateScheduledTaxRateOptions : INestedOptions
    {
        /// <summary>
        /// The tax rates to be applied.
        /// </summary>
        [JsonProperty("rates")]
        [STJS.JsonPropertyName("rates")]
        public List<ManualRuleUpdateScheduledTaxRateRateOptions> Rates { get; set; }

        /// <summary>
        /// The start time for the tax rate.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public DateTime? StartsAt { get; set; }
    }
}
