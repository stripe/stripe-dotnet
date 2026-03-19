// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplyEffectiveAtOptions : INestedOptions
    {
        /// <summary>
        /// When the apply action will take effect.
        /// One of: <c>current_billing_period_end</c>, <c>next_billing_period_start</c>, or
        /// <c>on_reserve</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
