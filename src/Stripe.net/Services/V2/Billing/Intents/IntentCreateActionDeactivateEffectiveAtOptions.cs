// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionDeactivateEffectiveAtOptions : INestedOptions
    {
        /// <summary>
        /// The timestamp at which the deactivate action will take effect. Only present if type is
        /// timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// When the deactivate action will take effect.
        /// One of: <c>current_billing_period_end</c>, <c>current_billing_period_start</c>,
        /// <c>on_reserve</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
