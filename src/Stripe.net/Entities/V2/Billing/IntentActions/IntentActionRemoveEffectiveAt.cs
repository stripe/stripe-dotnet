// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionRemoveEffectiveAt : StripeEntity<IntentActionRemoveEffectiveAt>
    {
        /// <summary>
        /// When the remove action takes effect.
        /// One of: <c>current_billing_period_end</c>, or <c>on_reserve</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
