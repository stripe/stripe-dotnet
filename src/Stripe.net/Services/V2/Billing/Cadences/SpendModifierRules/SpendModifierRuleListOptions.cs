// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Cadences
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SpendModifierRuleListOptions : V2.ListOptions
    {
        /// <summary>
        /// Return only spend modifiers that are effective at the specified timestamp.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public DateTime? EffectiveAt { get; set; }
    }
}
