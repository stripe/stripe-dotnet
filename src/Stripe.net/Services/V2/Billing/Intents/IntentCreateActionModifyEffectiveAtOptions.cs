// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionModifyEffectiveAtOptions : INestedOptions
    {
        /// <summary>
        /// The timestamp at which the modify action will take effect. Only present if type is
        /// timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// When the modify action will take effect.
        /// One of: <c>current_billing_period_start</c>, <c>on_reserve</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
