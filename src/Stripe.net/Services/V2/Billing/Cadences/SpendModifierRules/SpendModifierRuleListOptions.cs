// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Cadences
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SpendModifierRuleListOptions : V2.ListOptions
    {
        /// <summary>
        /// Return only spend modifiers that are effective at the specified timestamp.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public DateTime? EffectiveAt { get; set; }
    }
}
