// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionRemoveEffectiveAt : StripeEntity<IntentActionRemoveEffectiveAt>
    {
        /// <summary>
        /// When the remove action will take effect.
        /// One of: <c>current_billing_period_end</c>, or <c>on_reserve</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
